using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Threading;
using QuanLyThuVien_WF.Models;
using QuanLyThuVien_WF.Controller;
using System.Collections.Generic;
using QuanLyThuVien_WF.BLL;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcDocGia : UserControl
    {
        public UcDocGia()
        {
            InitializeComponent();
        }
        Controller.DocGia_Controller c = new Controller.DocGia_Controller();
        int flag = 0;
        public void DVG_DocGia()
        {
            dvgDocGia.DataSource = c.Select_DocGia();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgdg.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgdg.FocusedRowHandle >= 0;
        }
        public void LoadCBB()
        {
            CbbGioiTinh.Properties.Items.Clear();
            string[] gt = { "Nam", "Nữ" };
            foreach (string _gt in gt)
            {
                CbbGioiTinh.Properties.Items.Add(_gt.ToString());
            }
        }
        void LoadDocGiaID()
        {
            SinhVien_Controller sinhVien_Controller = new SinhVien_Controller();
            List<SinhVien> sinhViens = sinhVien_Controller.Select_SinhVien();
            List<DtoDocGiaID> dtoDocGiaIDs = new List<DtoDocGiaID>();
            foreach (SinhVien _sinhVien in sinhViens)
            {
                dtoDocGiaIDs.Add(new DtoDocGiaID { DocGiaID = _sinhVien.MaSV, NgheNghiep = "Sinh viên" });
            }
            GiaoVien_Controller giaoVien_Controller = new GiaoVien_Controller();
            List<GiaoVien> giaoVien_ = giaoVien_Controller.Select_GiaoVien();
            foreach (GiaoVien _giaoVien in giaoVien_)
                dtoDocGiaIDs.Add(new DtoDocGiaID { DocGiaID = _giaoVien.MaGV, NgheNghiep = "Giáo Viên" });
            cbbDocGiaID.DataSource = dtoDocGiaIDs;
            cbbDocGiaID.DisplayMember = "DocGiaID";
        }
        void dis_end(bool e)
        {
            TxtMaDocGia.Enabled = e;
            TxtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            CbbGioiTinh.Enabled = false;
            TxtDiaChi.Enabled = false;
            TxtDienThoai.Enabled = false;
            cbbDocGiaID.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgdg.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgdg.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtMaDocGia.Text = "";
            TxtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            CbbGioiTinh.Text = "";
            TxtDiaChi.Text = "";
            TxtDienThoai.Text = "";
            cbbDocGiaID.Text = "";
            LoadCBB();
        }
        private void UcDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGiaID();
            DVG_DocGia();
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
            LoadCBB();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madg = "";
                madg = TxtMaDocGia.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + madg + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Xoa_DocGia(madg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công độc giả " + madg, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_DocGia();
                        UcDocGia_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công độc giả " + madg, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (TxtMaDocGia.Text == "" || TxtHoTen.Text == "" || tt == "" || TxtDiaChi.Text == "" || TxtDienThoai.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string iddg = cbbDocGiaID.Text;
                string madg = "";
                try
                {
                    madg = TxtMaDocGia.Text;
                }
                catch
                {
                }
                string tendg = "";
                try
                {
                    tendg = TxtHoTen.Text;
                    string s = TxtHoTen.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    tendg = s;
                }
                catch
                {
                }
                string gioitinhdg = "";
                try
                {
                    gioitinhdg = CbbGioiTinh.Text;
                }
                catch { }
                DateTime ngaysinhdg = Convert.ToDateTime(dtpNgaySinh.EditValue);
                try { }
                catch { }
                string diachidg = "";
                try
                {
                    diachidg = TxtDiaChi.Text;
                    string s = TxtDiaChi.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    diachidg = s;
                }
                catch { }
                string sdtdg = "";
                try
                {
                    sdtdg = TxtDienThoai.Text;
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Them_DocGia(madg, iddg, tendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tendg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_DocGia();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tendg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Sua_DocGia(madg, iddg, tendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + madg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVG_DocGia();
                        UcDocGia_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + madg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcDocGia_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcDocGia_Load(sender, e);
            dis_end(false);
        }
        private void dvgdg_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaDocGia.Text = dvgdg.GetFocusedRowCellDisplayText(MaDG);
            cbbDocGiaID.Text = dvgdg.GetFocusedRowCellDisplayText(DocGiaID);
        }

        private void cbbDocGiaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDocGiaID.SelectedIndex>=0)
            {
                DtoDocGiaID dtoDocGiaID = (DtoDocGiaID)cbbDocGiaID.SelectedItem;
                lblNgheNghiep.Text = dtoDocGiaID.NgheNghiep;
                if (dtoDocGiaID.NgheNghiep.ToLower()=="sinh viên")
                {
                    SinhVien_Controller sinhVien_Controller = new SinhVien_Controller();
                    SinhVien sinhvien = sinhVien_Controller.Get_SV(dtoDocGiaID.DocGiaID);
                    TxtHoTen.Text = sinhvien.TenSV;
                    dtpNgaySinh.EditValue = sinhvien.NgaySinh;
                    CbbGioiTinh.Text = sinhvien.GioiTinh;
                    TxtDiaChi.Text = sinhvien.DiaChi;
                    TxtDienThoai.Text = sinhvien.DienThoai;
                }
                else
                {
                    GiaoVien_Controller giaoVien_Controller = new GiaoVien_Controller();
                    GiaoVien giaovien = giaoVien_Controller.Get_GV(dtoDocGiaID.DocGiaID);
                    TxtHoTen.Text = giaovien.TenGV;
                    dtpNgaySinh.EditValue = giaovien.NgaySinh;
                    CbbGioiTinh.Text = giaovien.GioiTinh;
                    TxtDiaChi.Text = giaovien.DiaChi;
                    TxtDienThoai.Text = giaovien.DienThoai;
                }
            }
            else
            {
                lblNgheNghiep.Text = "-";
            }
        }
    }
}
