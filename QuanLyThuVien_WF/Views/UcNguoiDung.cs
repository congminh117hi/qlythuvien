using DevExpress.XtraEditors;
using QuanLyThuVien_WF.Controller;
using QuanLyThuVien_WF.Models;
using System;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcNguoiDung : UserControl
    {
        public UcNguoiDung()
        {
            InitializeComponent();
        }

        readonly NguoiDung_Controller c = new NguoiDung_Controller();
        readonly ThuThu_Controller tt = new ThuThu_Controller();
        
        int flag = 0;
        public void Load_DVG()
        { 
            dvgNguoiDung.DataSource = c.Select_NguoiDung();
            //Ẩn nút xóa nếu ko có data
            BtnXoa.Enabled = dvgnd.FocusedRowHandle >= 0;
        }
        public void Load_CBB()
        {
            cbbMaTT.DataSource = tt.Select_ThuThu();
            cbbMaTT.DisplayMember = "MaTT";
            cbbMaTT.SelectedIndex = -1;
            Quyen_Controller q = new Quyen_Controller();
            cbbQuyen.DataSource = q.Select_Quyen();
            cbbQuyen.DisplayMember = "MaQuyen";
            cbbQuyen.SelectedIndex = -1;
        }
        private void dvgts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dvgnd.FocusedRowHandle>=0)
            {
                SetDataDetail();
            }
        }
        void SetDataDetail()
        {
            TxtMaNguoiDung.Text = dvgnd.GetFocusedRowCellDisplayText(MaND);
            cbbMaTT.SelectedIndex = cbbMaTT.FindStringExact(dvgnd.GetFocusedRowCellDisplayText(MaTT));
            txtNhapLai.Text = txtMatKhau.Text = dvgnd.GetFocusedRowCellValue(MatKhau).ToString();
            PhanQuyen_Controller q = new PhanQuyen_Controller();
            PhanQuyen phanQuyen = q.Get_PQ(TxtMaNguoiDung.Text);
            cbbQuyen.SelectedIndex = cbbQuyen.FindStringExact(phanQuyen.MaQuyen);
        }
        void dis_end(bool e)
        {
            TxtMaNguoiDung.Enabled = e;
            cbbMaTT.Enabled = e;
            txtMatKhau.Enabled = e;
            txtNhapLai.Enabled = e;
            cbbQuyen.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa nếu grid không có data
                BtnXoa.Enabled = dvgnd.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextEdit || item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void UcNguoiDung_Load(object sender, EventArgs e)
        {
            Load_DVG();
            Load_CBB();
            dis_end(false);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            flag = 0;
            dis_end(true);
            cleanData();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maND =  TxtMaNguoiDung.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + maND + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_ND(maND);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + maND, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcNguoiDung_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thành công " + maND, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Load_DVG();
                    }    


                }
                else
                    return;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string maND = TxtMaNguoiDung.Text;
            string MaTT = cbbMaTT.Text;
            string MatKhau = txtMatKhau.Text;
            if (txtMatKhau.Text!=txtNhapLai.Text)
            {
                XtraMessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            if (TxtMaNguoiDung.Text == "" || cbbMaTT.SelectedIndex<0)
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                if (flag == 0)
                {
                    NguoiDung_Controller n = new NguoiDung_Controller();
                    NguoiDung nguoiDung = n.Get_NguoiDung(maND);
                    if (nguoiDung != null)
                    {
                        XtraMessageBox.Show($"Mã người dùng {maND} đã tồn tại");
                        return;
                    }

                    int i = c.Insert_ND(maND, MaTT, MatKhau);
                    if (i <= 0)
                    {
                        XtraMessageBox.Show("Thêm không thành công " + maND, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    PhanQuyen_Controller phanQuyen = new PhanQuyen_Controller();
                    i = phanQuyen.Insert_PQ(TxtMaNguoiDung.Text, cbbQuyen.Text);
                    if (i <= 0)
                    {
                        XtraMessageBox.Show("Thêm không thành công " + maND, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    XtraMessageBox.Show("Thêm mới thành công " + maND, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DVG();
                    BtnHuyBo.PerformClick();
                }
            }
        }
        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcNguoiDung_Load(sender, e);
            dis_end(false);
        }

        private void cbbMaTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbMaTT.SelectedIndex<0)
                {
                    lblTenTT.Text = "-";
                    return;
                }
                ThuThu_Controller thuThu_Controller = new ThuThu_Controller();
                Select_TT_Result thuThu = (Select_TT_Result)cbbMaTT.SelectedItem;
                lblTenTT.Text = thuThu.TenTT;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi {ex.Message}");
            }
        }

        private void dvgNguoiDung_Load(object sender, EventArgs e)
        {
            if (dvgnd.FocusedRowHandle >= 0)
            {
                SetDataDetail();
            }
        }
    }
}
