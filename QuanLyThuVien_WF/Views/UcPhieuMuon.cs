using DevExpress.XtraEditors;
using QuanLyThuVien_WF.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcPhieuMuon : UserControl
    {
        public UcPhieuMuon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public void Load_DVG()
        { dvgPhieuMuon.DataSource = Controller.PhieuMuon_Controller.Select_PM();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgpm.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgpm.FocusedRowHandle >= 0;
        }
        private void dvgpm_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaPM.Text = dvgpm.GetFocusedRowCellDisplayText(MaPM);
            DtpNgayTra.EditValue = dvgpm.GetFocusedRowCellDisplayText(NgayTra);
            DtpNgayMuon.EditValue = dvgpm.GetFocusedRowCellDisplayText(NgayMuon);
            CbbDocGia.Text = dvgpm.GetFocusedRowCellDisplayText(TenDG);
            CbbMaCS.Text = dvgpm.GetFocusedRowCellDisplayText(MaCS);
            CbbTenThuThu.Text = dvgpm.GetFocusedRowCellDisplayText(TenTT);
            CbbTinhTrang.Text = dvgpm.GetFocusedRowCellDisplayText(TinhTrang);
            CbbTuaSach.Text = dvgpm.GetFocusedRowCellDisplayText(TenTS);
        }
        public void LoadCBB()
        {
            CbbTinhTrang.Properties.Items.Clear();
            string[] tt = { "Tốt", "Cũ" };
            foreach (string _tt in tt)
            {
                CbbTinhTrang.Properties.Items.Add(_tt.ToString());
            }

            CbbTuaSach.DataSource = Controller.PhieuMuon_Controller.Cbb_TS();
            CbbTuaSach.ValueMember = "MaTS";
            CbbTuaSach.SelectedIndex = -1;

            CbbDocGia.DataSource= Controller.PhieuMuon_Controller.Cbb_DG();
            CbbDocGia.ValueMember = "MaDG";
            CbbDocGia.SelectedIndex = -1;

            CbbTenThuThu.DataSource = Controller.PhieuMuon_Controller.Cbb_TT();
            CbbTenThuThu.ValueMember = "MaTT";
            CbbTenThuThu.SelectedIndex = -1;
            
            CbbMaCS.DataSource = Controller.PhieuMuon_Controller.Cbb_CS();
            CbbMaCS.ValueMember = "MaCS";
            CbbMaCS.SelectedIndex = -1;
        }
        void dis_end(bool e)
        {
            TxtMaPM.Enabled = e;
            CbbDocGia.Enabled = e;
            CbbMaCS.Enabled = e;
            CbbTenThuThu.Enabled = e;
            CbbTinhTrang.Enabled = e;
            CbbTuaSach.Enabled = e;
            DtpNgayMuon.Enabled = e;
            DtpNgayTra.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgpm.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgpm.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtMaPM.Text = "";
            CbbTuaSach.Text = "";
            CbbTinhTrang.Text = "";
            CbbTenThuThu.Text = "";
            CbbMaCS.ResetText();
            CbbDocGia.Text = "";
            DtpNgayMuon.ResetText();
            DtpNgayTra.ResetText();
        }
        private void UcPhieuMuon_Load(object sender, EventArgs e)
        {
            Load_DVG();
            LoadCBB();
            dis_end(false);
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
                string mapm = "";
                mapm = TxtMaPM.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + mapm + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = Controller.PhieuMuon_Controller.Delete_PM(mapm);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công mã phiếu " + mapm, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcPhieuMuon_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công mã phiếu " + mapm, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string ngtra = DtpNgayTra.Text.ToString();
            string ngmuon = DtpNgayMuon.Text.ToString();
            if (TxtMaPM.Text == "" || CbbDocGia.Text == "" || CbbMaCS.Text == "" || CbbTenThuThu.Text == "" || CbbTinhTrang.Text == "" || ngtra == "" || ngmuon== "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string mapm = "";
                try
                {
                    mapm = TxtMaPM.Text;
                }
                catch
                {
                }
                DateTime ngaymuon = Convert.ToDateTime(DtpNgayMuon.EditValue);
                try
                {
                }
                catch
                {
                }
                DateTime ngaytra = Convert.ToDateTime(DtpNgayTra.EditValue);
                try
                {
                }
                catch
                {
                }
                string madg = "";
                try
                {
                    madg = CbbDocGia.Text;
                }
                catch { }
                string matt = "";
                try
                {
                    matt = CbbTenThuThu.Text;
                }
                catch { }
                string macs = "";
                try
                {
                    macs = CbbMaCS.Text;
                }
                catch { }
                string tinhtrang = "";
                try
                {
                    tinhtrang = CbbTinhTrang.Text;
                }
                catch { }
               
                if (flag == 0)
                {
                    int i = 0;
                    i = Controller.PhieuMuon_Controller.Insert_PM(mapm, ngaymuon, ngaytra, madg, matt, macs, tinhtrang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + mapm, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công " + mapm, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = Controller.PhieuMuon_Controller.Update_PM(mapm, ngaymuon, ngaytra, madg, matt, macs, tinhtrang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + mapm, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcPhieuMuon_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + mapm, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcPhieuMuon_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcPhieuMuon_Load(sender, e);
            dis_end(false);
        }
    }
}
