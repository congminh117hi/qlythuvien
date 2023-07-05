using System;
using QuanLyThuVien_WF.Models;
namespace QuanLyThuVien_WF.Controller
{
    class DocGia_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_DocGia(string madg, string iddg, string tendg, string gioitinhdg, DateTime ngaysinhdg, string diachidg, string sdtdg)
        {
            try
            {
                return db.Insert_DG(madg,iddg, tendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_DocGia(string madg, string iddg, string tendg, string gioitinhdg, DateTime ngaysinhdg, string diachidg, string sdtdg)
        {
            try
            {
                return db.Update_DG(madg, iddg, tendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_DocGia(string madg)
        {
            try
            {
                return db.Delete_DG(madg);
            }
            catch
            {
                return 0;
            }
        }
        public Object Select_DocGia()
        {
            return db.Select_DG();
        }
    }
}
