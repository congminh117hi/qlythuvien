using DevExpress.XtraEditors;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcNhaCungCap : UserControl
    {
        public UcNhaCungCap()
        {
            InitializeComponent();
        }
        Controller.NhaCungCap_Controller c = new Controller.NhaCungCap_Controller();
        int flag = 0;
        public void Load_DVG()
        {
            dvgNhaCC.DataSource = c.Select_NCC();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvncc.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvncc.FocusedRowHandle >= 0;
        }
        void dis_end(bool e)
        {
            TxtMaNCC.Enabled = e;
            TxtTenNCC.Enabled = e;
            TxtDiaChi.Enabled = e;
            TxtDienThoai.Enabled = e;
            TxtEmail.Enabled = e;
            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvncc.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvncc.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtMaNCC.Text = "";
            TxtTenNCC.Text = "";
            TxtEmail.Text = "";
            TxtDiaChi.Text = "";
            TxtDienThoai.Text = "";
        }
        private void UcNhaCungCap_Load(object sender, EventArgs e)
        {
            Load_DVG();
            dis_end(false);
        }

        private void dvncc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaNCC.Text = dvncc.GetFocusedRowCellDisplayText(MaNCC);
            TxtTenNCC.Text = dvncc.GetFocusedRowCellDisplayText(TenNCC);
            TxtDiaChi.Text = dvncc.GetFocusedRowCellDisplayText(DiaChi);
            TxtDienThoai.Text = dvncc.GetFocusedRowCellDisplayText(SDT);
            TxtEmail.Text = dvncc.GetFocusedRowCellDisplayText(Email);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            cleanData();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mancc = "";
                mancc = TxtMaNCC.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + mancc + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.IDelete_NCC(mancc);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công nhà cung cấp " + mancc, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcNhaCungCap_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành nhà cung cấp " + mancc, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (TxtMaNCC.Text == "" || TxtTenNCC.Text == "" || TxtEmail.Text == "" || TxtDiaChi.Text == "" || TxtDienThoai.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string mancc = "";
                try
                {
                    mancc = TxtMaNCC.Text;
                }
                catch
                {
                }
                string tenncc = "";
                try
                {
                    tenncc = TxtTenNCC.Text;
                    string s = TxtTenNCC.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    tenncc = s;
                }
                catch
                {
                }
                string diachincc = "";
                try
                {
                    diachincc = TxtDiaChi.Text;
                    string s = TxtDiaChi.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    diachincc = s;
                }
                catch { }
                string sdtncc = "";
                try
                {
                    sdtncc = TxtDienThoai.Text;
                }
                catch { }
                string email = "";
                try
                { email = TxtEmail.Text; }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_NCC(mancc, tenncc, diachincc, sdtncc, email);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tenncc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tenncc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Update_NCC(mancc, tenncc, diachincc, sdtncc, email);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + mancc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcNhaCungCap_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + mancc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcNhaCungCap_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcNhaCungCap_Load(sender, e);
            dis_end(false);
        }

        private void TxtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
