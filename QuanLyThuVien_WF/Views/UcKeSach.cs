using DevExpress.XtraEditors;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcKeSach : UserControl
    {
        public UcKeSach()
        {
            InitializeComponent();
        }
        Controller.KeSach_Controller c = new Controller.KeSach_Controller();
        int flag=0;
        public void Load_DVG()
        {
            dvgKeSach.DataSource = c.Select_KS();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgks.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgks.FocusedRowHandle >= 0;
        }
        void dis_end(bool e)
        {
            TxtMaKeSach.Enabled = e;
            TxtChatLieu.Enabled = e;
            TxtSucChua.Enabled = e;
            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgks.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgks.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtChatLieu.Text = "";
            TxtMaKeSach.Text = "";
            TxtSucChua.Text = "";
            TxtSoLuong.Text = "";
        }
        private void UcKeSach_Load(object sender, EventArgs e)
        {
            Load_DVG();
            dis_end(false);
        }

        private void dvgks_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaKeSach.Text = dvgks.GetFocusedRowCellDisplayText(MaKe);
            TxtChatLieu.Text = dvgks.GetFocusedRowCellDisplayText(ChatLieu);
            TxtSoLuong.Text = dvgks.GetFocusedRowCellDisplayText(SL);
            TxtSucChua.Text = dvgks.GetFocusedRowCellDisplayText(SucChua);
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
                string make = "";
                make = TxtMaKeSach.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + make + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_KS(make);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công kệ sách " + make, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcKeSach_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công kệ sách " + make, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (TxtMaKeSach.Text == "" || TxtChatLieu.Text == "" || TxtSucChua.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string make = "";
                try
                {
                    make = TxtMaKeSach.Text;
                }
                catch
                {
                }
                string chatlieu = "";
                try
                {
                    chatlieu = TxtChatLieu.Text;
                    string s = TxtChatLieu.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    chatlieu = s;
                }
                catch
                {
                }
                int succhua = int.Parse(TxtSucChua.Text);
                try
                {
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_KS(make, chatlieu, succhua);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + make, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công " + make, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Update_KS(make, chatlieu, succhua);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + make, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcKeSach_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + make, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcKeSach_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcKeSach_Load(sender, e);
            dis_end(false);
        }

        private void TxtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}
