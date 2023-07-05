using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class UcCuonSach : UserControl
    {
        public UcCuonSach()
        {
            InitializeComponent();
        }
        Controller.CuonSach_Controller c = new Controller.CuonSach_Controller();
        int flag = 0;
        public void Load_DVG()
        { dvgCuonSach.DataSource = c.Select_CS();
            //Ẩn nút xóa nếu ko có data
            BtnXoa.Enabled = dvgcs.FocusedRowHandle >= 0;
        }
        public void Load_CBB()
        {
            CbbTuaSach.DataSource = c.Cbb_TS();
            CbbTuaSach.ValueMember = "MaTS";
            CbbTuaSach.SelectedIndex = -1;
        }
        private void dvgts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMaCuonSach.Text = dvgcs.GetFocusedRowCellDisplayText(MaCS);
            CbbTuaSach.Text = dvgcs.GetFocusedRowCellDisplayText(TenTS);
        }
        void dis_end(bool e)
        {
            TxtMaCuonSach.Enabled = e;
            CbbTuaSach.Enabled = e;

            BtnLuu.Enabled = e;
            BtnHuyBo.Enabled = e;
            BtnThem.Enabled = !e;
            BtnXoa.Enabled = !e;
            if (e == false)
            {
                //Ẩn nút xóa nếu grid không có data
                BtnXoa.Enabled = dvgcs.FocusedRowHandle >= 0;
            }
        }
        void cleanData()
        {
            TxtMaCuonSach.Text = "";
            CbbTuaSach.Text = "";
           
        }
        private void dvgCuonSach_Load(object sender, EventArgs e)
        {

        }

        private void UcCuonSach_Load(object sender, EventArgs e)
        {
            Load_DVG();
            Load_CBB();
            dis_end(false);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            flag = 0;
            dis_end(true);
            cleanData();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string macs = "";
                macs = TxtMaCuonSach.Text;
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn xóa " + macs + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = c.Delete_CS(macs);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công " + macs, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                        UcCuonSach_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công " + macs, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (TxtMaCuonSach.Text == "" || CbbTuaSach.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string macs = "";
                try
                {
                    macs = TxtMaCuonSach.Text;
                }
                catch
                {
                }

                string mats = "";
                try
                {
                    mats = CbbTuaSach.Text;
                }
                catch { }

                if (flag == 0)
                {
                    int i = 0;
                    i = c.Insert_CS(macs, mats);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công " + macs, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DVG();
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công " + macs, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            UcCuonSach_Load(sender, e);
            dis_end(false);
            
        }
    }
}
