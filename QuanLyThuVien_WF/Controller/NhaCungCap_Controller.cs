using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class NhaCungCap_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_NCC(string mancc, string tenncc, string diachincc, string sdtncc, string email)
        {
            try
            {
                return db.Insert_NCC(mancc, tenncc, diachincc, sdtncc, email);
            }
            catch
            {
                return 0;
            }
        }
        public int Update_NCC(string mancc, string tenncc, string diachincc, string sdtncc, string email)
        {
            try
            {
                return db.Update_NCC(mancc, tenncc, diachincc, sdtncc, email);
            }
            catch
            {
                return 0;
            }
        }
        public int IDelete_NCC(string mancc)
        {
            try
            {
                return db.Delete_NCC(mancc);
            }
            catch
            {
                return 0;
            }
        }
        public Object Select_NCC()
        { return db.Select_NCC(); }
    }
}
