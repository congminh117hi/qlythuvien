using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Threading;
namespace QuanLyThuVien_WF.Views
{
    public partial class UcTacGia : UserControl
    {
        public UcTacGia()
        {
            InitializeComponent();
        }
        Controller.TacGia_Controller c = new Controller.TacGia_Controller();
        int flag = 0;
        public void Load_DVG()
        { dvgTacGia.DataSource = c.Select_TG();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgtg.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgtg.FocusedRowHandle >= 0;
        }
        public void Load_GT()
        {
            CbbGioiTinh.Properties.Items.Clear();
            string[] gt = { "Nam", "Nữ" };
            foreach (string _gt in gt)
            {
                CbbGioiTinh.Properties.Items.Add(_gt.ToString());
            }
        }
        void dis_end(bool e)
        {
            TxtMaTG.Enabled = e;
            TxtHoTen.Enabled = e;
            dtpNgaySinh.Enabled = e;
            CbbGioiTinh.Enabled = e;
            TxtDiaChi.Enabled = e;
            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgtg.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgtg.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtMaTG.Text = "";
            TxtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            CbbGioiTinh.Text = "";
            TxtDiaChi.Text = "";
            Load_GT();
        }
        private void UcTacGia_Load(object sender, EventArgs e)
        {
            Load_DVG();
            dis_end(false);
        }

        private void dvgtg_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaTG.Text = dvgtg.GetFocusedRowCellDisplayText(MaTG);
            TxtHoTen.Text = dvgtg.GetFocusedRowCellDisplayText(TenTG);
            CbbGioiTinh.Text = dvgtg.GetFocusedRowCellDisplayText(GioiTinh);
            dtpNgaySinh.EditValue = dvgtg.GetFocusedRowCellDisplayText(NgaySinh);
            TxtDiaChi.Text = dvgtg.GetFocusedRowCellDisplayText(QueQuan);
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
            Load_GT();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string matg = "";
                matg = TxtMaTG.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + matg + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_TG(matg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công tác giả " + matg, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcTacGia_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công tác giả " + matg, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string tt = dtpNgaySinh.Text.ToString();
            if (TxtMaTG.Text == "" || TxtHoTen.Text == "" || tt == "" || TxtDiaChi.Text == "" || CbbGioiTinh.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string matg = "";
                try
                {
                    matg = TxtMaTG.Text;
                }
                catch
                {
                }
                string tentg = "";
                try
                {
                    tentg = TxtHoTen.Text;
                    string s = TxtHoTen.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    tentg = s;
                }
                catch
                {
                }
                string gioitinhtg = "";
                try
                {
                    gioitinhtg = CbbGioiTinh.Text;
                }
                catch { }
                DateTime ngaysinhtg = Convert.ToDateTime(dtpNgaySinh.EditValue);
                try { }
                catch { }
                string quequantg = "";
                try
                {
                    quequantg = TxtDiaChi.Text;
                    string s = TxtDiaChi.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    quequantg = s;
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_TG(matg, tentg, gioitinhtg, ngaysinhtg, quequantg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tentg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tentg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Update_TG(matg, tentg, gioitinhtg, ngaysinhtg, quequantg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + matg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcTacGia_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + matg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcTacGia_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcTacGia_Load(sender, e);
            dis_end(false);
        }
    }
}
