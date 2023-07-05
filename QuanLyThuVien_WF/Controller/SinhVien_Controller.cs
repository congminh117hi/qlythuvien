using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class SinhVien_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_SinhVien(string maSV, string tenSV, string maLop, string gioitinhSV, DateTime ngaysinhSV, string diachiSV, string sdtSV)
        {
            try
            {
                return db.Insert_SV(maSV, tenSV, maLop, sdtSV, diachiSV, ngaysinhSV, gioitinhSV);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_SinhVien(string maSV, string tenSV, string maLop, string gioitinhSV, DateTime ngaysinhSV, string diachiSV, string sdtSV)
        {
            try
            {
                return db.Update_SV(maSV, tenSV, maLop, sdtSV, diachiSV, ngaysinhSV, gioitinhSV);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_SinhVien(string maSV)
        {
            try
            {
                return db.Delete_SV(maSV);
            }
            catch
            {
                return 0;
            }
        }
        public SinhVien Get_SV(string MaSV)
        {
            return db.SinhViens.FirstOrDefault(x=>x.MaSV==MaSV);
        }
        public List<SinhVien> Select_SinhVien()
        {
            return db.SinhViens.ToList();
        }
        public List<SinhVien> Select_SinhVien_Theo_Lop(string MaLop)
        {
            return db.SinhViens.Where(x=>x.MaLop==MaLop).ToList();
        }
    }
}
