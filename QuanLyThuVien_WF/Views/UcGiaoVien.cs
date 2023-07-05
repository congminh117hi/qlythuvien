using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Threading;
using QuanLyThuVien_WF.Controller;
using QuanLyThuVien_WF.Models;
using System.Collections.Generic;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcGiaoVien : UserControl
    {
        public UcGiaoVien()
        {
            InitializeComponent();
        }
        Controller.GiaoVien_Controller c = new Controller.GiaoVien_Controller();
        int flag = 0;
        public void Load_DVG()
        {
            c = new GiaoVien_Controller();
            dvgGiaoVien.DataSource = c.Select_GiaoVien();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvggv.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvggv.FocusedRowHandle >= 0;
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
            txtMaGV.Enabled = e;
            TxtHoTen.Enabled = e;
            cbbMaKhoa.Enabled = e;
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
                BtnCapNhat.Enabled = dvggv.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvggv.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            txtMaGV.Text = "";
            TxtHoTen.Text = "";
            cbbMaKhoa.Text = "";
            txtDienThoai.Text = "";
            CbbGioiTinh.Text = "";
            dtpNgaySinh.EditValue = "";
            TxtDiaChi.Text = "";
            Load_GT();
        }
        private void UcGiaoVien_Load(object sender, EventArgs e)
        {
            Load_Khoa();
            Load_DVG();
            dis_end(false);
        }

        private void Load_Khoa()
        {
            Khoa_Controller lop_Controller = new Khoa_Controller();
            List<Khoa> Khoas = lop_Controller.Select_Khoa();
            cbbMaKhoa.DataSource= Khoas;
            cbbMaKhoa.DisplayMember = "MaKhoa";
        }

        private void dvgGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaGV.Text = dvggv.GetFocusedRowCellDisplayText(MaGV);
            TxtHoTen.Text = dvggv.GetFocusedRowCellDisplayText(TenGV);
            cbbMaKhoa.Text = dvggv.GetFocusedRowCellDisplayText(MaKhoa);
            txtDienThoai.Text = dvggv.GetFocusedRowCellDisplayText (DienThoai);
            CbbGioiTinh.Text = dvggv.GetFocusedRowCellDisplayText(GioiTinh);
            dtpNgaySinh.EditValue = dvggv.GetFocusedRowCellDisplayText(NgaySinh);
            TxtDiaChi.Text = dvggv.GetFocusedRowCellDisplayText(DiaChi);
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
                string maGV = "";
                maGV = txtMaGV.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + maGV + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Xoa_GiaoVien(maGV);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + maGV, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcGiaoVien_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công " + maGV, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtMaGV.Text == "" || TxtHoTen.Text == "" || tt == "" || TxtDiaChi.Text == "" || CbbGioiTinh.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string maGV =  txtMaGV.Text;
                string s = TxtHoTen.Text;
                s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                string tenGV = s;

                string gioitinhGV = CbbGioiTinh.Text;
                
                DateTime ngaysinhGV = Convert.ToDateTime(dtpNgaySinh.EditValue);
                string quequanGV = TxtDiaChi.Text;
                s = TxtDiaChi.Text;
                s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                quequanGV = s;
                string MaKhoa = cbbMaKhoa.Text;
                string sdt = txtDienThoai.Text;
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Them_GiaoVien(maGV, tenGV,MaKhoa, gioitinhGV, ngaysinhGV, quequanGV, sdt);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tenGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công" + tenGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Sua_GiaoVien(maGV, tenGV, MaKhoa, gioitinhGV, ngaysinhGV, quequanGV, sdt);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + maGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcGiaoVien_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + maGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcGiaoVien_Load(sender, e);
            }
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcGiaoVien_Load(sender, e);
            dis_end(false);
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaKhoa.SelectedIndex >= 0)
            {
                Khoa khoa = (Khoa)cbbMaKhoa.SelectedItem;
                lblKhoa.Text = "Khoa " + khoa.TenKhoa;
            }
            else
                lblKhoa.Text = "Khoa";
        }

        private void txtMaGV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtMaGV.Enabled && flag == 0)
            {
                GiaoVien_Controller giaoVien_Controller = new GiaoVien_Controller();
                GiaoVien giaoVien = giaoVien_Controller.Get_GV(txtMaGV.Text);
                if (giaoVien != null)
                {
                    XtraMessageBox.Show($"Mã giáo viên {txtMaGV.Text} đã được sử dụng", "Trùng ID");
                    BtnLuu.Enabled = false;
                }
                else
                    BtnLuu.Enabled = true;
            }
        }
    }
}
