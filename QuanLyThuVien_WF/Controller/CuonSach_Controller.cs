using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class CuonSach_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_CS(string macs, string mats)
        {
            try
            {
                return db.Insert_CS(macs, mats);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_CS(string macs)
        {
            try
            {
                return db.Delete_CS(macs);
            }
            catch
            {
                return 0;
            }
        }
        public Object Cbb_TS()
        { return db.Cbb_TS(); }
        public Object Select_CS()
        { return db.Select_CS(); }
    }
}
