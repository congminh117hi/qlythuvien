using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Threading;
using QuanLyThuVien_WF.Controller;
using QuanLyThuVien_WF.Models;
using System.Collections.Generic;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcSinhVien : UserControl
    {
        public UcSinhVien()
        {
            InitializeComponent();
        }
        Controller.SinhVien_Controller c = new Controller.SinhVien_Controller();
        int flag = 0;
        public void Load_DVG()
        {
            c = new SinhVien_Controller();
            dvgSinhVien.DataSource = c.Select_SinhVien();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgsv.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgsv.FocusedRowHandle >= 0;
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
            txtMaSV.Enabled = e;
            TxtHoTen.Enabled = e;
            cbbMaLop.Enabled = e;
            txtDienThoai.Enabled = e;
            CbbGioiTinh.Enabled = e;
            dtpNgaySinh.Enabled = e;
            TxtDiaChi.Enabled = e;


            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgsv.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgsv.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            txtMaSV.Text = "";
            TxtHoTen.Text = "";
            cbbMaLop.Text = "";
            txtDienThoai.Text = "";
            CbbGioiTinh.Text = "";
            dtpNgaySinh.EditValue = "";
            TxtDiaChi.Text = "";
            Load_GT();
        }
        private void UcSinhVien_Load(object sender, EventArgs e)
        {
            Load_Lop();
            Load_DVG();
            dis_end(false);
        }

        private void Load_Lop()
        {
            Lop_Controller lop_Controller = new Lop_Controller();
            List<Lop> Lops = lop_Controller.Select_Lop();
            cbbMaLop.DataSource= Lops;
            cbbMaLop.DisplayMember = "MaLop";
        }

        private void dvgSV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaSV.Text = dvgsv.GetFocusedRowCellDisplayText(MaSV);
            TxtHoTen.Text = dvgsv.GetFocusedRowCellDisplayText(TenSV);
            cbbMaLop.Text = dvgsv.GetFocusedRowCellDisplayText(MaLop);
            txtDienThoai.Text = dvgsv.GetFocusedRowCellDisplayText (DienThoai);
            CbbGioiTinh.Text = dvgsv.GetFocusedRowCellDisplayText(GioiTinh);
            dtpNgaySinh.EditValue = dvgsv.GetFocusedRowCellDisplayText(NgaySinh);
            TxtDiaChi.Text = dvgsv.GetFocusedRowCellDisplayText(DiaChi);
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
                string maSV = "";
                maSV = txtMaSV.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + maSV + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Xoa_SinhVien(maSV);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + maSV, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Load_DVG();
                        UcSinhVien_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công " + maSV, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtMaSV.Text == "" || TxtHoTen.Text == "" || tt == "" || TxtDiaChi.Text == "" || CbbGioiTinh.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string maSV =  txtMaSV.Text;
                string s = TxtHoTen.Text;
                s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                string tenSV = s;

                string gioitinhSV = CbbGioiTinh.Text;
                
                DateTime ngaysinhSV = Convert.ToDateTime(dtpNgaySinh.EditValue);
                string quequanSV = TxtDiaChi.Text;
                s = TxtDiaChi.Text;
                s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                quequanSV = s;
                string MaLop = cbbMaLop.Text;
                string sdt = txtDienThoai.Text;
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Them_SinhVien(maSV, tenSV,MaLop, gioitinhSV, ngaysinhSV, quequanSV, sdt);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tenSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tenSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Sua_SinhVien(maSV, tenSV, MaLop, gioitinhSV, ngaysinhSV, quequanSV, sdt);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + maSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + maSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcSinhVien_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcSinhVien_Load(sender, e);
            dis_end(false);
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedIndex >= 0)
            {
                Lop lop = (Lop)cbbMaLop.SelectedItem;
                Khoa_Controller khoa_Controller = new Khoa_Controller();
                Khoa khoa = khoa_Controller.Get_Khoa(lop.MaKhoa);
                lblKhoa.Text = "Khoa " + khoa.TenKhoa;
            }
            else
                lblKhoa.Text = "Khoa";
        }
        
        private void txtMaSV_Validated(object sender, EventArgs e)
        {
            //Kiểm tra trùng mã
            if (txtMaSV.Enabled && flag==0)
            {
                SinhVien_Controller sinhVien_Controller = new SinhVien_Controller();
                SinhVien sinhVien = sinhVien_Controller.Get_SV(txtMaSV.Text);
                if (sinhVien != null)
                {
                    XtraMessageBox.Show($"Mã sinh viên {txtMaSV.Text} đã được sử dụng", "Trùng ID");
                    BtnLuu.Enabled = false;
                }
                else
                    BtnLuu.Enabled=true;
            }
        }
    }
}
