using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class Lop_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_Lop(string maLop, string maKhoa)
        {
            try
            {
                return db.Insert_Lop(maLop, maKhoa);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_Lop(string maLop, string maKhoa)
        {
            try
            {
                return db.Update_Lop(maLop, maKhoa);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_Lop(string maLop)
        {
            try
            {
                return db.Delete_Lop(maLop);
            }
            catch
            {
                return 0;
            }
        }
        public Lop Get_Lop(string MaLop)
        {
            return db.Lops.FirstOrDefault(x => x.MaLop == MaLop);
        }
        public List<Lop> Select_Lop()
        {
            return db.Lops.ToList();
        }
        public List<Lop> Select_Lop_Theo_Khoa(string MaKhoa)
        {
            return db.Lops.Where(x=>x.MaKhoa==MaKhoa).ToList();
        }
    }
}
