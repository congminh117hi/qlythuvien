using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class PhieuMuon_Controller
    {
        public static QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public static int Insert_PM(string mapm, Nullable<System.DateTime> ngaymuon, Nullable<System.DateTime> ngaytra, string madg, string matt, string macs, string tinhtrang)
        {
            try
            {
                return db.Insert_PhieuMuon(mapm, ngaymuon, ngaytra, madg, matt, macs, tinhtrang);
            }
            catch
            {
                return 0;
            }
        }
        public static int Update_PM(string mapm, Nullable<System.DateTime> ngaymuon, Nullable<System.DateTime> ngaytra, string madg, string matt, string macs, string tinhtrang)
        {
            try
            {
                return db.Update_PhieuMuon(mapm, ngaymuon, ngaytra, madg, matt, macs, tinhtrang);
            }
            catch
            {
                return 0;
            }
        }
        public static int Delete_PM(string mapm)
        {
            try
            {
                return db.Delete_PM(mapm);
            }
            catch
            {
                return 0;
            }
        }
        public static Object Select_PM()
        { return db.Select_PM(); }
        public static Object Cbb_TS()
        { return db.Cbb_TS(); }
        public static Object Cbb_TT()
        { return db.Cbb_TT(); }
        public static Object Cbb_DG()
        { return db.Cbb_DG(); }
        public static Object Cbb_CS()
        { return db.Cbb_CS(); }
    }
}
