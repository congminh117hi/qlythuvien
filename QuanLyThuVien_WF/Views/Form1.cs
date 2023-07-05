using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QuanLyThuVien_WF.BLL;
using QuanLyThuVien_WF.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien_WF
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            btnNguoiDung.Enabled = LogInUser.MaNguoiDung.ToUpper() == "ADMIN";
        }
        AddTab.TabAdd add = new AddTab.TabAdd();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thông Tin Thủ Thư");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thông Tin Thủ Thư", new UcThuThu());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thông Tin Thủ Thư")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thông Tin Thủ Thư", new UcThuThu());
            //}
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thông Tin Độc Giả");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thông Tin Độc Giả", new UcDocGia());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thông Tin Độc Giả")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thông Tin Độc Giả", new UcDocGia());
            //}
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thông Tin Tựa Sách");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thông Tin Tựa Sách", new UcTuaSach());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thông Tin Tựa Sách")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thông Tin Tựa Sách", new UcTuaSach());
            //}
        }

        private void TabHienThi_CloseButtonClick(object sender, System.EventArgs e)
        {
            // ko cho đóng cái tab home
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            XtraTabPage closingPage = (XtraTabPage)arg.Page;
            if (closingPage != tabHome)
                TabHienThi.TabPages.Remove(closingPage);
        }

        private void TabHienThi_ControlAdded(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            TabHienThi.SelectedTabPageIndex = TabHienThi.TabPages.Count - 1;
        }

        private void ribbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thông Tin Kho Sách");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thông Tin Kho Sách", new UcCuonSach());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thông Tin Kho Sách")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thông Tin Kho Sách", new UcCuonSach());
            //}
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Tác Giả");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Tác Giả", new UcTacGia());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Tác Giả")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Tác Giả", new UcTacGia());
            //}
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Nhà Xuất Bản");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Nhà Xuất Bản", new UcNhaXuatBan());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Nhà Xuất Bản")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Nhà Xuất Bản", new UcNhaXuatBan());
            //}
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Kệ Sách");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Kệ Sách", new UcKeSach());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Kệ Sách")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Kệ Sách", new UcKeSach());
            //}
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Nhà Cung Cấp");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Nhà Cung Cấp", new UcNhaCungCap());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Nhà Cung Cấp")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Nhà Cung Cấp", new UcNhaCungCap());
            //}
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Phiếu Nhập");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Phiếu Nhập", new UcPhieuNhap());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Phiếu Nhập")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Phiếu Nhập", new UcPhieuNhap());
            //}
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thông Tin Phiếu Mượn");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thông Tin Phiếu Mượn", new UcPhieuMuon());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thông Tin Phiếu Mượn")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thông Tin Phiếu Mượn", new UcPhieuMuon());
            //}
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Thống Kê Mượn - Trả");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Thống Kê Mượn - Trả", new UcThongKe());
            }
            else
                TabHienThi.SelectedTabPage = page;
            //int i = 0;
            //foreach (DevExpress.XtraTab.XtraTabPage tab in TabHienThi.TabPages)
            //{
            //    if (tab.Text == "Thống Kê Mượn - Trả")
            //    {
            //        TabHienThi.SelectedTabPage = tab;
            //        i = 1;
            //    }
            //}
            //if (i == 1)
            //{ }
            //else
            //{
            //    add.AddTab(TabHienThi, "", "Thống Kê Mượn - Trả", new UcThongKe());
            //}
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            report.ShowPreview();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport2 report = new XtraReport2();
            report.ShowPreview();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport3 report = new XtraReport3();
            report.ShowPreview();
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Cuốn Sách");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Cuốn Sách", new UcCuonSach());
            }
            else
                TabHienThi.SelectedTabPage = page;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Người Dùng");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Người Dùng", new UcNguoiDung());
            }
            else
                TabHienThi.SelectedTabPage = page;
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Sinh Viên");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Sinh Viên", new UcSinhVien());
            }
            else
                TabHienThi.SelectedTabPage = page;
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Giáo Viên");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Giáo Viên", new UcGiaoVien());
            }
            else
                TabHienThi.SelectedTabPage = page;
        }

        private void btnKhoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = TabHienThi.TabPages.FirstOrDefault(x => x.Text == "Khoa - Lớp");
            if (page == null)
            {
                add.AddTab(TabHienThi, "", "Khoa - Lớp", new UcKhoaLop());
            }
            else
                TabHienThi.SelectedTabPage = page;
        }

        private void btnGioiThieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGioiThieu frmGioiThieu = new FrmGioiThieu();
            frmGioiThieu.ShowDialog();
        }
    }
}
