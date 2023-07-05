using System;
using QuanLyThuVien_WF.Models;
namespace QuanLyThuVien_WF.Controller
{
    class TacGia_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_TG(string matg, string tentg, string gioitinhtg, Nullable<System.DateTime> ngaysinhtg, string quequantg)
        {
            try
            {
                return db.Insert_TG(matg, tentg, gioitinhtg, ngaysinhtg, quequantg);
            }
            catch 
            {
                return 0;
            }
        }
        public int Update_TG(string matg, string tentg, string gioitinhtg, Nullable<System.DateTime> ngaysinhtg, string quequantg)
        {
            try
            {
                return db.Update_TG(matg, tentg, gioitinhtg, ngaysinhtg, quequantg);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_TG(string matg)
        {
            try
            {
                return db.Delete_TG(matg);
            }
            catch
            {
                return 0;
            }
        }
        public Object Select_TG()
        { return db.Select_TG(); }
    }
}
