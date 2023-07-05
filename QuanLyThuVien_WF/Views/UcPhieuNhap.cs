using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcPhieuNhap : UserControl
    {
        public UcPhieuNhap()
        {
            InitializeComponent();
        }
        Controller.PhieuNhap_Controller c = new Controller.PhieuNhap_Controller();
        int flag = 0;
        public void Load_DVG()
        { dvgPhieuNhap.DataSource = c.Select_PN();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgpn.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgpn.FocusedRowHandle >= 0;
        }
        public void Load_Cbb()
        {
            CbbNhaCC.DataSource = c.CBB_NCC();
            CbbNhaCC.ValueMember = "MaNCC";
            CbbNhaCC.SelectedIndex = -1;

            CbbTenThuThu.DataSource = c.CBB_TT();
            CbbTenThuThu.ValueMember = "MaTT";
            CbbTenThuThu.SelectedIndex = -1;

            CbbTuaSach.DataSource = c.CBB_TS();
            CbbTuaSach.ValueMember = "MaTS";
            CbbTuaSach.SelectedIndex = -1;
        }
        void dis_end(bool e)
        {
            TxtMaPN.Enabled = e;
            TxtDonGia.Enabled = e;
            TxtSoLuong.Enabled = e;
            CbbTuaSach.Enabled = e;
            CbbTenThuThu.Enabled = e;
            CbbNhaCC.Enabled = e;
            DtpNgayLap.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgpn.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgpn.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtTongTien.Text = "";
            TxtThanhTien.Text = "";
            TxtSoLuong.Text = "";
            TxtMaPN.Text = "";
            TxtDonGia.Text = "";
            CbbNhaCC.Text = "";
            CbbTenThuThu.Text = "";
            CbbTuaSach.Text = "";
            DtpNgayLap.ResetText();
        }
        private void UcPhieuNhap_Load(object sender, EventArgs e)
        {
            Load_DVG();
            Load_Cbb();
            dis_end(false);
        }

        private void dvgpn_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaPN.Text = dvgpn.GetFocusedRowCellDisplayText(MaPN);
            CbbTenThuThu.Text = dvgpn.GetFocusedRowCellDisplayText(TenTT);
            CbbTuaSach.Text = dvgpn.GetFocusedRowCellDisplayText(TenTS);
            DtpNgayLap.EditValue = dvgpn.GetFocusedRowCellDisplayText(NgayLap);
            CbbNhaCC.Text = dvgpn.GetFocusedRowCellDisplayText(TenNCC);
            TxtSoLuong.Text = dvgpn.GetFocusedRowCellDisplayText(SoLuong);
            TxtDonGia.Text = dvgpn.GetFocusedRowCellDisplayText(DonGia);
            TxtThanhTien.Text = dvgpn.GetFocusedRowCellDisplayText(TT);
            TxtTongTien.Text = dvgpn.GetFocusedRowCellDisplayText(TongTien);
        }

        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
            Load_DVG();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = "";
                mapn = TxtMaPN.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + mapn + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_PhieuNhap(mapn);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công mã phiếu " + mapn, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcPhieuNhap_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công mã phiếu " + mapn, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string tt = DtpNgayLap.Text.ToString();
            if (TxtMaPN.Text == "" || TxtSoLuong.Text == "" || TxtDonGia.Text == "" || tt == "" || CbbNhaCC.Text == "" || CbbTenThuThu.Text == "" || CbbTuaSach.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string mapn = "";
                try
                {
                    mapn = TxtMaPN.Text;
                }
                catch
                {
                }
                DateTime ngaylap = Convert.ToDateTime(DtpNgayLap.EditValue);
                try
                {
                }
                catch
                {
                }
                string matt = "";
                try
                {
                    matt = CbbTenThuThu.Text;
                }
                catch { }
                string mancc = "";
                try
                {
                    mancc = CbbNhaCC.Text;
                    
                }
                catch { }
                string mats = "";
                try
                {
                    mats = CbbTuaSach.Text;
                }
                catch { }
                int soluong = int.Parse(TxtSoLuong.Text);
                try
                {
                }
                catch { }
                int dongia = int.Parse(TxtDonGia.Text);
                try
                {
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_PN(mapn, ngaylap, matt, mancc, mats, soluong, dongia);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + mapn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công " + mapn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Update_PN(mapn, ngaylap, matt, mancc, mats, soluong, dongia);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + mapn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcPhieuNhap_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + mapn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcPhieuNhap_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcPhieuNhap_Load(sender, e);
            dis_end(false);
        }

    }
}
