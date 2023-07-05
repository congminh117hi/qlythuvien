using DevExpress.XtraEditors;
using QuanLyThuVien_WF.Controller;
using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcKhoaLop : DevExpress.XtraEditors.XtraUserControl
    {
        public UcKhoaLop()
        {
            InitializeComponent();
        }
        Controller.Khoa_Controller c = new Controller.Khoa_Controller();
        Lop_Controller l = new Lop_Controller();
        int flag = 0;
        public void Load_DVG()
        {
            dvgKhoa.DataSource = c.Select_Khoa();
            //Ẩn nút xóa và cập nhật
            BtnXoaKhoa.Enabled = dvgkh.FocusedRowHandle >= 0;
        }
        void dis_en_Khoa(bool e)
        {
            TxtMaKhoa.Enabled = e && flag==0;
            txtTenKhoa.Enabled = e;
            groupControl2.Enabled = !e;
            dvgKhoa.Enabled = !e;

            BtnLuuKhoa.Enabled = e;
            BtnHuyBoKhoa.Enabled = e;
            BtnThemKhoa.Enabled = !e;
            BtnXoaKhoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa
                BtnXoaKhoa.Enabled = dvgkh.FocusedRowHandle >= 0;
                BtnThemLop.Enabled = dvgkh.FocusedRowHandle >= 0;
            }
        }
        void dis_en_Lop(bool e)
        {
            txtMaLop.Enabled = e;

            BtnLuuLop.Enabled = e;
            BtnHuyBoLop.Enabled = e;
            BtnThemLop.Enabled = !e;
            BtnXoaLop.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa
                BtnXoaLop.Enabled = dvglp.FocusedRowHandle >= 0;
            }
        }
        void cleanKhoaData()
        {
            TxtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }
        void cleanLopData()
        {
            txtMaLop.Text = "";
            TxtMaKh.Text = dvgkh.GetFocusedRowCellDisplayText(MaKhoa);
        }

        private void UcKhoaLop_Load(object sender, EventArgs e)
        {
            Load_DVG();
            dis_en_Khoa(false);
            dis_en_Lop(false);
        }

        private void dvgkh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            checkKhoaData();
        }
        private void dvgKhoa_DataSourceChanged(object sender, EventArgs e)
        {
            checkKhoaData();
        }
        private void dvgKhoa_Load(object sender, EventArgs e)
        {
            checkKhoaData();
        }
        void checkKhoaData()
        {
            if (dvgkh.FocusedRowHandle >= 0)
            {
                Lop_Controller lc = new Lop_Controller();
                List<Lop> lops = lc.Select_Lop_Theo_Khoa(dvgkh.GetFocusedRowCellDisplayText(MaKhoa));
                if (lops.Count > 0)
                {
                    BtnXoaKhoa.Enabled = false; //Nếu khoa đã có lớp thì ko cho xóa
                }
                dvgLop.DataSource = lops;
                TxtMaKhoa.Text = dvgkh.GetFocusedRowCellDisplayText(MaKhoa);
                txtTenKhoa.Text = dvgkh.GetFocusedRowCellDisplayText(TenKhoa);
            }
            else
                cleanKhoaData();

        }
        private void dvglp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CheckLopData();
        }
        private void dvgLop_Load(object sender, EventArgs e)
        {
            CheckLopData();
        }

        private void dvgLop_DataSourceChanged(object sender, EventArgs e)
        {
            CheckLopData();
        }
        void CheckLopData()
        {
            if (dvglp.FocusedRowHandle >= 0)
            {
                SinhVien_Controller sc = new SinhVien_Controller();
                List<SinhVien> svs = sc.Select_SinhVien_Theo_Lop(dvglp.GetFocusedRowCellDisplayText(MaLop));
                if (svs.Count > 0)
                {
                    BtnXoaLop.Enabled = false; //Nếu lớp đã có SV thì ko cho xóa
                }
                txtMaLop.Text = dvglp.GetFocusedRowCellDisplayText(MaLop);
                TxtMaKh.Text = dvglp.GetFocusedRowCellValue(clMaKhoa).ToString();
            }
            else
                cleanLopData();
        }
        private void BtnThemKhoa_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en_Khoa(true);
            cleanKhoaData();
        }

        private void BtnHuyBoKhoa_Click(object sender, EventArgs e)
        {
            Load_DVG();
            dis_en_Khoa(false);
            dis_en_Lop(false);
        }

        private void BtnXoaKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makhoa = "";
                makhoa = TxtMaKhoa.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + makhoa + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Xoa_Khoa(makhoa);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + makhoa, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        dis_en_Khoa(false);
                        dis_en_Lop(false);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công " + makhoa, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    return;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaKhoa.Text)||string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                XtraMessageBox.Show("Cần điền đủ thông tin mã khoa và tên khoa", "Thiếu thông tin");
                return;
            }
            string makhoa = TxtMaKhoa.Text;
            string tenkhoa = txtTenKhoa.Text;
            if (flag == 0)
            {
                int i = c.Them_Khoa(makhoa,tenkhoa);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công " + tenkhoa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DVG();
                    dis_en_Khoa(false);
                    dis_en_Lop(false);
                }
                else
                    XtraMessageBox.Show("Thêm không thành công" + tenkhoa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnThemLop_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en_Lop(true);
            cleanLopData();
        }

        private void BtnHuyBoLop_Click(object sender, EventArgs e)
        {
            int index = dvgkh.FocusedRowHandle;
            Load_DVG();
            if (dvgkh.FocusedRowHandle!=index)
                dvgkh.FocusedRowHandle = index;
            dis_en_Khoa(false);
            dis_en_Lop(false);
        }

        private void BtnXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = "";
                malop = txtMaLop.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + malop + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = l.Xoa_Lop(malop);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + malop, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        dis_en_Khoa(false);
                        dis_en_Lop(false);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công " + malop, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    return;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLuuLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                XtraMessageBox.Show("Cần điền thông tin mã lớp", "Thiếu thông tin");
                return;
            }
            string malop = txtMaLop.Text;
            string makhoa = TxtMaKh.Text;
            if (flag == 0)
            {
                int i = l.Them_Lop(malop, makhoa);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công " + malop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DVG();
                    dis_en_Khoa(false);
                    dis_en_Lop(false);
                }
                else
                    XtraMessageBox.Show("Thêm không thành công" + malop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
