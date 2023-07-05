using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class NhaXuatBan_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_NXB(string manxb, string tennxb, string diachinxb, string sdtnxb, string emailnxb)
        {
            try
            {
                return db.Insert_NXB(manxb, tennxb, diachinxb, sdtnxb, emailnxb);
            }
            catch
            {
                return 0;
            }
        }
        public int Update_NXB(string manxb, string tennxb, string diachinxb, string sdtnxb, string emailnxb)
        {
            try
            {
                return db.Update_NXB(manxb, tennxb, diachinxb, sdtnxb, emailnxb);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_NXB(string manxb)
        {
            try
            {
                return db.Delete_NXB(manxb);
            }
            catch
            {
                return 0;
            }
        }
        public Object Select_NXB()
        { return db.Select_NXB(); }
    }
}
