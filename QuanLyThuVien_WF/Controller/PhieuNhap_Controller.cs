using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class PhieuNhap_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_PN(string mapn, Nullable<System.DateTime> ngaylap, string matt, string mancc, string mats, Nullable<int> soluong, Nullable<int> dongia)
        {
            try
            {
                return db.Insert_PhieuNhap(mapn, ngaylap, matt, mancc,mats,soluong,dongia);
            }
            catch
            {
                return 0;
            }
        }
        public int Update_PN(string mapn, Nullable<System.DateTime> ngaylap, string matt, string mancc, string mats, Nullable<int> soluong, Nullable<int> dongia)
        {
            try
            {
                return db.Update_PhieuNhap(mapn, ngaylap, matt, mancc, mats, soluong, dongia);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_PhieuNhap(string mapn)
        {
            try
            {
                return db.Delete_PN(mapn);
            }
            catch
            {
                return 0;
            }
        }

        public Object Select_PN()
        { return db.Select_PN(); }
        public Object CBB_TS()
        { return db.Cbb_TS(); }
        public Object CBB_NCC()
        { return db.Cbb_NCC(); }
        public Object CBB_TT()
        { return db.Cbb_TT(); }
    }
}
