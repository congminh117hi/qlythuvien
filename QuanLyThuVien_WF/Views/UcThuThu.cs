using System;
//using System.Data;
//using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcThuThu : UserControl
    {
        public UcThuThu()
        {
            InitializeComponent();
        }
        Controller.ThuThu_Controller c = new Controller.ThuThu_Controller();
        int flag = 0;
        public void DVG_THUTHU()
        {
            dvgThuThu.DataSource = c.Select_ThuThu();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgtt.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgtt.FocusedRowHandle >= 0;
        }

        public void LoadCbb()
        {
            CbbGioiTinh.Properties.Items.Clear();
            string[] gt = { "Nam", "Nữ" };
            foreach (string _gt in gt)
            {
                CbbGioiTinh.Properties.Items.Add(_gt.ToString());
            }
        }
        private void UcThuThu_Load(object sender, EventArgs e)
        {
            DVG_THUTHU();
            dis_end(false);
        }

        private void dvgtt_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtThuThu.Text = dvgtt.GetFocusedRowCellDisplayText(MaTT);
            TxtHoTen.Text = dvgtt.GetFocusedRowCellDisplayText(TenTT);
            dtpNgaySinh.EditValue= dvgtt.GetFocusedRowCellDisplayText(NgaySinh);
            CbbGioiTinh.Text= dvgtt.GetFocusedRowCellDisplayText(GioiTinh);
            TxtDiaChi.Text = dvgtt.GetFocusedRowCellDisplayText(DiaChi);
            TxtDienThoai.Text = dvgtt.GetFocusedRowCellDisplayText(SDT);
            TxtChucVu.Text = dvgtt.GetFocusedRowCellDisplayText(Chucvu);
        }
        void dis_end(bool e)
        {
            TxtThuThu.Enabled = e;
            TxtHoTen.Enabled = e;
            dtpNgaySinh.Enabled = e;
            CbbGioiTinh.Enabled = e;
            TxtDiaChi.Enabled = e;
            TxtDienThoai.Enabled = e;
            TxtChucVu.Enabled = e;
            
            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgtt.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgtt.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtThuThu.Text = "";
            TxtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            CbbGioiTinh.Text = "";
            TxtDiaChi.Text = "";
            TxtDienThoai.Text = "";
            TxtChucVu.Text="";
            LoadCbb();
        }

        #region Xóa
      
        #endregion
        #region Lưu
    
        #endregion
        private void BtnThem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            cleanData();
        }

        private void BtnCapNhat_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            LoadCbb();
        }

        private void BtnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string matt = "";
                matt = TxtThuThu.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + matt + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.XOA_THUTHU(matt);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công thủ thư " + matt, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_THUTHU();
                        UcThuThu_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công thủ thư " + matt, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    return;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLuu_Click_1(object sender, EventArgs e)
        {
            string tt = dtpNgaySinh.Text.ToString();
            if (TxtThuThu.Text == "" || TxtHoTen.Text == "" || tt == "" || TxtDiaChi.Text == "" || TxtDienThoai.Text == "" || TxtChucVu.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string matt = "";
                try
                {
                    matt = TxtThuThu.Text;
                }
                catch
                {
                }
                string tentt = "";
                try
                {
                    tentt = TxtHoTen.Text;
                    string s = TxtHoTen.Text;
                    s = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());// chuẩn hóa
                    tentt = s;
                }
                catch
                {
                }
                string gioitinhtt = "";
                try
                {
                    gioitinhtt = CbbGioiTinh.Text;
                }
                catch { }
                DateTime ngaysinhtt = Convert.ToDateTime(dtpNgaySinh.EditValue);
                try { }
                catch { }
                string diachitt = "";
                try
                {
                    diachitt = TxtDiaChi.Text;
                    string s = TxtDiaChi.Text;
                    s = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    diachitt = s;
                }
                catch { }
                string sdttt = "";
                try
                {
                    sdttt = TxtDienThoai.Text;
                }
                catch { }
                string chucvu = "";
                try
                {
                    chucvu = TxtChucVu.Text;
                    string s = TxtChucVu.Text;
                    s = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    chucvu = s;
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.THEM_THUTHU(matt, tentt, gioitinhtt, ngaysinhtt, diachitt, sdttt, chucvu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tentt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_THUTHU();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tentt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.UPDATE_THUTHU(matt, tentt, gioitinhtt, ngaysinhtt, diachitt, sdttt, chucvu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + matt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_THUTHU();
                        UcThuThu_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + matt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcThuThu_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click_1(object sender, EventArgs e)
        {
            UcThuThu_Load(sender, e);
            dis_end(false);
        }
    }
}
