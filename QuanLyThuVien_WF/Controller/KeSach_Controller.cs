using System;
using QuanLyThuVien_WF.Models;
namespace QuanLyThuVien_WF.Controller
{
    class KeSach_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_KS(string make, string chatlieu, Nullable<int> succhua)
        {
            try
            {
              return  db.Insert_KeSach(make, chatlieu, succhua);
            }
            catch
            {
                return 0;
            }
        }
        public int Update_KS(string make, string chatlieu, Nullable<int> succhua)
        {
            try
            {
                return db.Update_KeSach(make, chatlieu, succhua);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_KS(string make)
        {
            try
            {
                return db.Delete_KeSach(make);
            }
            catch
            {
                return 0;
            }
        }
        public Object Select_KS()
        { return db.Select_KeSach(); }
    }
}
