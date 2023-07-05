using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcNhaXuatBan : UserControl
    {
        public UcNhaXuatBan()
        {
            InitializeComponent();
        }
        Controller.NhaXuatBan_Controller c = new Controller.NhaXuatBan_Controller();
        int flag = 0;
        public void Load_DVG()
        {
            dvgNXB.DataSource = c.Select_NXB();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dgnxb.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dgnxb.FocusedRowHandle >= 0;
        }
        void dis_end(bool e)
        {
            TxtMaNXB.Enabled = e;
            TxtNXB.Enabled = e;
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
                BtnCapNhat.Enabled = dgnxb.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dgnxb.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtNXB.Text = "";
            TxtMaNXB.Text = "";
            TxtEmail.Text = "";
            TxtDiaChi.Text = "";
            TxtDienThoai.Text = "";
        }
        private void UcNhaXuatBan_Load(object sender, EventArgs e)
        {
            Load_DVG();
            dis_end(false);
        }

        private void dgnxb_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaNXB.Text = dgnxb.GetFocusedRowCellDisplayText(MaNXB);
            TxtNXB.Text = dgnxb.GetFocusedRowCellDisplayText(TenNXB);
            TxtDiaChi.Text = dgnxb.GetFocusedRowCellDisplayText(DiaChi);
            TxtDienThoai.Text = dgnxb.GetFocusedRowCellDisplayText(SDT);
            TxtEmail.Text = dgnxb.GetFocusedRowCellDisplayText(Email);
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
                string manxb = "";
                manxb = TxtMaNXB.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + manxb + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_NXB(manxb);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công nhà xuất bản " + manxb, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcNhaXuatBan_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành nhà xuất bản " + manxb, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
           
            if (TxtMaNXB.Text == "" || TxtNXB.Text == "" || TxtEmail.Text == "" || TxtDiaChi.Text == "" || TxtDienThoai.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string manxb = "";
                try
                {
                    manxb = TxtMaNXB.Text;
                }
                catch
                {
                }
                string tennxb = "";
                try
                {
                    tennxb = TxtNXB.Text;
                    string s = TxtNXB.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    tennxb = s;
                }
                catch
                {
                }
                string diachinxb = "";
                try
                {
                    diachinxb = TxtDiaChi.Text;
                    string s = TxtDiaChi.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    diachinxb = s;
                }
                catch { }
                string sdtnxb = "";
                try
                {
                    sdtnxb = TxtDienThoai.Text;
                }
                catch { }
                string emailnxb = "";
                try
                { emailnxb = TxtEmail.Text; }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_NXB(manxb, tennxb, diachinxb, sdtnxb, emailnxb);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tennxb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tennxb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Update_NXB(manxb, tennxb, diachinxb, sdtnxb, emailnxb);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + manxb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcNhaXuatBan_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + manxb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcNhaXuatBan_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcNhaXuatBan_Load(sender, e);
            dis_end(false);
        }

        private void TxtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
