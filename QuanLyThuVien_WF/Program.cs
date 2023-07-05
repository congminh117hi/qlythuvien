using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using QuanLyThuVien_WF.Views;

namespace QuanLyThuVien_WF
{
    static class Program
    {
        public static bool quit = false;
        public static bool go = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            do
            {
                Application.Run(new FrmLogin());
            } while (quit == false);
            if (go)
            {
                Application.Run(new Form1());
            }
        }
    }
}
