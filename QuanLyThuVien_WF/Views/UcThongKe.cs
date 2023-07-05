using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using QuanLyThuVien_WF.BLL;
using QuanLyThuVien_WF.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcThongKe : UserControl
    {
        public UcThongKe()
        {
            InitializeComponent();
            dateEdit1.EditValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateEdit2.EditValue = DateTime.Today;
        }
        public void Dvg_Load(DateTime from, DateTime to, int trangthai)
        {
            ThongKe_Controller thongKe_Controller = new ThongKe_Controller();
            List<DtoThongKe> dtoThongKes = thongKe_Controller.ThongKeMuonSach(from, to, trangthai);
            tlDaMuon.DataSource = dtoThongKes;
            tlDaMuon.ChildListFieldName = "ChiTiets";
            foreach (TreeListNode item in tlDaMuon.Nodes)
            {
                if (item.HasChildren)
                {
                    item.Expand();
                }
            }
        }
        private void UcThongKe_Load(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dateEdit1.EditValue;
            DateTime date2 = (DateTime)dateEdit2.EditValue;
            Dvg_Load(date, date2, 0);
            Doc_ChuaMuon();
        }

        private void Doc_ChuaMuon()
        {
            ThongKe_Controller thongKe_Controller = new ThongKe_Controller();
            List<DtoChuaMuon> list = thongKe_Controller.ThongKeChuaMuon();
            tlChuaMuon.DataSource = list;
            tlChuaMuon.ChildListFieldName = "ChiTiets";
            foreach(TreeListNode item in tlChuaMuon.Nodes)
            { 
                if (item.Level==0)
                { 
                    item.Expand(); 
                }
            }
        }

        bool CheckDate()
        {
            DateTime date = (DateTime)dateEdit1.EditValue;
            DateTime date2 = (DateTime)dateEdit2.EditValue;
            return DateTime.Compare(date,date2) <= 0;
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (!CheckDate())
            {
                XtraMessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Lỗi");
                return;
            }
            if (cbbTinhTrang.SelectedIndex<0)
            {
                XtraMessageBox.Show("Vui lòng chọn tình trạng", "Lỗi");
                return;
            }
            DateTime date = (DateTime)dateEdit1.EditValue;
            DateTime date2 = (DateTime)dateEdit2.EditValue;
            Dvg_Load(date, date2, cbbTinhTrang.SelectedIndex);

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null)
                return;
            if (!CheckDate())
            {
                XtraMessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Lỗi");
            }
            else
            {
                DateTime date = (DateTime)dateEdit1.EditValue;
                DateTime date2 = (DateTime)dateEdit2.EditValue;
                Dvg_Load(date, date2, cbbTinhTrang.SelectedIndex);
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEdit2.EditValue == null) return;
            if (!CheckDate())
            {
                XtraMessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Lỗi");
            }
            else
            {
                DateTime date = (DateTime)dateEdit1.EditValue;
                DateTime date2 = (DateTime)dateEdit2.EditValue;
                Dvg_Load(date, date2, cbbTinhTrang.SelectedIndex);
            }

        }

        private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dateEdit1.EditValue;
            DateTime date2 = (DateTime)dateEdit2.EditValue;
            Dvg_Load(date,date2, cbbTinhTrang.SelectedIndex);
        }
    }
}
