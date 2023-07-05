using DevExpress.XtraEditors;
using QuanLyThuVien_WF.BLL;
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
using Telerik.WinControls.UI;
using Decorate = FormDecoration.Decorate;

namespace QuanLyThuVien_WF.Views
{
    public partial class FrmLogin : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter))
            {
                if (!(this.ActiveControl is SimpleButton))
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    return true;
                }
            }
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public FrmLogin()
        {
            InitializeComponent();
            foreach (Control item in Controls)
            {
                if (item is Label label)
                {
                    label.MouseMove += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseMove(FormTop, FormLeft, e);
                    };
                    label.MouseDown += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseDown();
                    };
                }
                if (item is Panel panel)
                {
                    panel.MouseMove += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseMove(FormTop, FormLeft, e);
                    };
                    panel.MouseDown += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseDown();
                    };
                }
                if (item is PictureBox picture)
                {
                    picture.MouseMove += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseMove(FormTop, FormLeft, e);
                    };
                    picture.MouseDown += delegate (object sender, MouseEventArgs e)
                    {
                        MyMouseDown();
                    };
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Decorate decorate = new Decorate();
            decorate.DrawHGradientBox(e,0,0,panel1.Width, panel1.Height, Color.DarkBlue, Color.Blue);
        }
        #region Hàm tự viết
        int MouseX;
        int MouseY;
        int FormTop;
        int FormLeft;
        void MyMouseMove(int mFormTop, int mFormLeft, MouseEventArgs e)
        {
            int mdx, mdy;
            mdx = Cursor.Position.X - MouseX;
            mdy = Cursor.Position.Y - MouseY;
            if (e.Button.ToString() == "Left")
            {
                Top = mFormTop + mdy;
                //if (Top < 0) Top = 0;
                Left = mFormLeft + mdx;
                //if (Left < 0) Left = 0;
            }
        }
        void MyMouseDown()
        {
            MouseX = Cursor.Position.X;
            MouseY = Cursor.Position.Y;
            FormLeft = Left;
            FormTop = Top;
        }

        #endregion

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MyMouseDown();
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            MyMouseMove(FormTop, FormLeft, e);
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool OKClick = false;

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!OKClick)
            {
                Program.quit = true;
                Program.go = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập ID và mật khẩu!");
                return;
            }
            PhanQuyen_Controller cphanQuyen = new PhanQuyen_Controller();
            PhanQuyen phanquyen = cphanQuyen.Get_PQ(txtUser.Text);
            if (phanquyen!=null)
            {
                NguoiDung_Controller nguoiDung_Controller = new NguoiDung_Controller();
                NguoiDung nguoiDung = nguoiDung_Controller.Get_NguoiDung(phanquyen.MaNguoiDung);
                if(nguoiDung==null)
                {
                    XtraMessageBox.Show($"Người dùng {phanquyen.MaNguoiDung} chưa được cấp quyền sử dụng", "Chưa cấp quyền",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (nguoiDung.MatKhau!=txtPass.Text)
                {
                    XtraMessageBox.Show($"Mật khẩu không đúng", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Quyen_Controller quyen_Controller = new Quyen_Controller();
                Quyen quyen = quyen_Controller.Get_Quyen(phanquyen.MaQuyen);
                ThuThu_Controller thuThu_Controller = new ThuThu_Controller();
                ThuThu thuThu = thuThu_Controller.Get_ThuThu(nguoiDung.MaTT);
                LogInUser.MaNguoiDung = nguoiDung.MaNguoiDung;
                LogInUser.TenNguoiDung = thuThu.TenTT;
                LogInUser.XemSach = quyen.XemSach.Value;
                LogInUser.SuaSach = quyen.SuaSach.Value;
                LogInUser.XoaSach = quyen.XoaSach.Value;
                LogInUser.ThemSach = quyen.ThemSach.Value;
                LogInUser.ThemNguoiDung = quyen.ThemNguoiDung.Value;
                LogInUser.SuaNguoiDung = quyen.SuaNguoiDung.Value;
                LogInUser.XemNguoiDung = quyen.XemNguoiDung.Value;
                LogInUser.XemNguoiDung = quyen.XoaNguoiDung.Value;
                LogInUser.XoaMuonTra = quyen.XoaMuonTra.Value;
                LogInUser.XemMuonTra = quyen.XemMuonTra.Value;
                LogInUser.ThemMuonTra = quyen.ThemMuonTra.Value;
                LogInUser.SuaMuonTra = quyen.SuaMuonTra.Value;

                Program.quit = true;
                Program.go = true;
                OKClick = true;
                Close();
            }
            else
            {
                XtraMessageBox.Show($"Người dùng {txtUser.Text} không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

        }
    }
}
