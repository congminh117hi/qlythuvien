using System;
using System.Data;
using QuanLyThuVien_WF.Models;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Threading;
using System.Linq;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcTuaSach : UserControl
    {
        public UcTuaSach()
        {
            InitializeComponent();
        }
        Controller.TuaSach_Controller c = new Controller.TuaSach_Controller();
        int flag = 0;
        public void Dvg_TuaSach()
        {
            dvgTuaSach.DataSource = c.SelectTS();
            //Ẩn nút xóa và cập nhật
            BtnCapNhat.Enabled = dvgts.FocusedRowHandle >= 0;
            BtnXoa.Enabled = dvgts.FocusedRowHandle >= 0;
        }
        #region Linq()
        public void Load_Cbb()
        {
            CbbNhaXuatBan.DataSource = c.NXB();
            CbbNhaXuatBan.ValueMember = "MaNXB";
            CbbNhaXuatBan.SelectedIndex = -1;

            CbbTacGia.DataSource = c.TacGia();
            CbbTacGia.ValueMember = "MaTG";
            CbbTacGia.SelectedIndex = -1;

            using (var ctx = new QuanLyThuVienEntities())
            {
                var List = ctx.KeSaches.SqlQuery("Select * from KeSach").ToList<KeSach>();
                CbbViTri.DataSource = List;
                CbbViTri.ValueMember = "MaKe";
                CbbViTri.SelectedIndex = -1;
            }
        }
        #endregion
        #region LoadCbb()
        //public void Load_Cbb2()
        //{
        //    // Khởi tạo một db mới
        //    // Gọi phương thức LoadAsync để không đồng bộ lấy dữ liệu cho DbSet nhất định từ cơ sở dữ liệu.
        //    // Liên kết dữ liệu để kiểm soát khi tải hoàn tất
        //    QuanLyThuVienEntities dbContext = new QuanLyThuVienEntities();
        //    dbContext.NXBs.LoadAsync().ContinueWith(loadTask =>
        //    {
        //        CbbNhaXuatBan.DataSource = dbContext.NXBs.Local.ToBindingList();
        //    }, TaskScheduler.FromCurrentSynchronizationContext());
        //    CbbNhaXuatBan.ValueMember = "MaNXB";
        //    CbbNhaXuatBan.DisplayMember = "TenNXB";
        //}
        //public void Load_TG()
        //{
        //    QuanLyThuVienEntities db_2 = new QuanLyThuVienEntities();
        //    db_2.TacGias.LoadAsync().ContinueWith(loadTask =>
        //    {
        //        CbbTacGia.Properties.DataSource = db_2.TacGias.Local.ToBindingList();
        //    }, TaskScheduler.FromCurrentSynchronizationContext());
        //    CbbTacGia.Properties.ValueMember = "MaTG";
        //}
        //public void Load_VT()
        //{
        //    QuanLyThuVienEntities db_3 = new QuanLyThuVienEntities();
        //    db_3.KeSaches.LoadAsync().ContinueWith(loadTask =>
        //    {
        //        CbbViTri.Properties.DataSource = db_3.KeSaches.Local.ToBindingList();
        //    }, TaskScheduler.FromCurrentSynchronizationContext());
        //    CbbViTri.Properties.ValueMember = "MaKe";

        //using (var ctx = new QuanLyThuVienEntities())
        //{
        //    var List = ctx.KeSaches.SqlQuery("Select * from KeSach").ToList<KeSach>();
        //    CbbViTri.DataSource = List;
        //   // CbbViTri.DisplayMember = "MaKe";
        //    CbbViTri.ValueMember = "MaKe";
        //    CbbViTri.SelectedIndex = -1;
        //}

        //using (var ctx = new QuanLyThuVienEntities())
        //{
        //    var List = ctx.TacGias.SqlQuery("select * from TacGia").ToList<TacGia>();
        //    CbbTacGia.DataSource = List;
        //   // CbbTacGia.DisplayMember = "TenTG";
        //    CbbTacGia.ValueMember = "MaTG";
        //    CbbTacGia.SelectedIndex = -1;
        //}
        //}
        #endregion
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
                string mats = "";
                mats = TxtMaTuaSach.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + mats + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Xoa_TuaSach(mats);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công mã sách " + mats, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dvg_TuaSach();
                        UcTuaSach_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công mã sách " + mats, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    return;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region btnLuu()
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (TxtMaTuaSach.Text == "" || TxtTenTua.Text == "" || TxtNamXB.Text == "" || TxtSoLuong.Text == "" || TxtSoTrang.Text == "" || TxtTheLoai.Text == "" || CbbNhaXuatBan.Text == "" || CbbTacGia.Text == "" || CbbViTri.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string mats = "";
                try
                {
                    mats = TxtMaTuaSach.Text;
                }
                catch
                {
                }
                string tents = "";
                try
                {
                    tents = TxtTenTua.Text;
                    string s = TxtTenTua.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    tents = s;
                }
                catch
                {
                }
                int namxb = int.Parse(TxtNamXB.Text);
                try
                {
                }
                catch { }
                string theloai = "";
                try
                {
                    theloai = TxtTheLoai.Text;
                    string s = TxtTheLoai.Text;
                    s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                    theloai = s;
                }
                catch { }
                string manxb = "";
                try
                {
                    manxb = CbbNhaXuatBan.Text;
                }
                catch { }
                string make = "";
                try
                {
                    make = CbbViTri.Text;
                }
                catch { }
                int soluong = int.Parse(TxtSoLuong.Text);
                try
                {
                }
                catch { }
                string matg = "";
                try
                {
                    matg = CbbTacGia.Text;
                }
                catch { }
                int sotrang = int.Parse(TxtSoTrang.Text);
                try
                {
                }
                catch { }
                if (flag == 0)
                {
                    int i = 0;
                    i = c.Them_TuaSach(mats, tents, namxb, theloai, manxb, make, soluong,matg,sotrang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + tents, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dvg_TuaSach();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công " + tents, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    i = c.Sua_TuaSach(mats, tents, namxb, theloai, manxb, make, soluong, matg, sotrang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công " + mats, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dvg_TuaSach();
                        UcTuaSach_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Sửa không thành công " + mats, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UcTuaSach_Load(sender, e);
            }
        }
        #endregion
        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcTuaSach_Load(sender, e);
            dis_end(false);
        }
        private void UcTuaSach_Load(object sender, EventArgs e)
        {
            Dvg_TuaSach();
            Load_Cbb();
            dis_end(false);
        }
        #region Luoi()
        //private int currenRowIndex;
        //private void LoadData()
        //{
        //    currenRowIndex = dvgts.FocusedRowHandle;
        //    if (currenRowIndex < 0) return;
        //    TxtMaTuaSach.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["MaTS"]).ToString();
        //    TxtTenTua.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["TenTS"]).ToString();
        //    TxtTheLoai.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["TheLoai"]).ToString();
        //    TxtNamXB.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["NamXB"]).ToString();
        //    TxtSoLuong.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["SoLuong"]).ToString();
        //    TxtSoTrang.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["SoTrang"]).ToString();
        //    CbbTacGia.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["TenTG"]).ToString();
        //    CbbViTri.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["MaKe"]).ToString();
        //    CbbNhaXuatBan.Text = dvgts.GetRowCellValue(currenRowIndex, dvgts.Columns["TenNXB"]).ToString();
        //}
        #endregion
        private void dvgts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaTuaSach.Text = dvgts.GetFocusedRowCellDisplayText(MaTS);
            TxtTenTua.Text = dvgts.GetFocusedRowCellDisplayText(TenTS);
            TxtNamXB.Text = dvgts.GetFocusedRowCellDisplayText(NamXB);
            TxtTheLoai.Text = dvgts.GetFocusedRowCellDisplayText(TheLoai);
            TxtSoTrang.Text = dvgts.GetFocusedRowCellDisplayText(SoTrang);
            CbbTacGia.Text = dvgts.GetFocusedRowCellDisplayText(TenTG);
            CbbNhaXuatBan.Text = dvgts.GetFocusedRowCellDisplayText(TenNXB);
            CbbViTri.Text = dvgts.GetFocusedRowCellDisplayText(MaKe);
            TxtSoLuong.Text = dvgts.GetFocusedRowCellDisplayText(SoLuong);
        }
        void dis_end(bool e)
        {
            TxtMaTuaSach.Enabled = e;
            TxtTenTua.Enabled = e;
            TxtNamXB.Enabled = e;
            TxtTheLoai.Enabled = e;
            TxtSoTrang.Enabled = e;
            CbbTacGia.Enabled = e;
            CbbViTri.Enabled = e;
            CbbNhaXuatBan.Enabled = e;
            TxtSoLuong.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnCapNhat.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa và cập nhật
                BtnCapNhat.Enabled = dvgts.FocusedRowHandle >= 0;
                BtnXoa.Enabled = dvgts.FocusedRowHandle >= 0;
            }
        }
        #region Xóa Trắng()
        void cleanData()
        {
            TxtMaTuaSach.Text = "";
            TxtTenTua.Text = "";
            TxtNamXB.Text = "";
            TxtTheLoai.Text = "";
            TxtSoTrang.Text = "";
            CbbTacGia.Text = "";
            CbbViTri.Text = "";
            TxtSoLuong.Text = "";
            CbbNhaXuatBan.Text = "";
        }
        #endregion
        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
