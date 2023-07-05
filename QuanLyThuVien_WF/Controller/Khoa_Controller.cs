using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class Khoa_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_Khoa(string maKhoa, string tenKhoa)
        {
            try
            {
                return db.Insert_Khoa(maKhoa, tenKhoa);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_Khoa(string maKhoa, string tenKhoa)
        {
            try
            {
                return db.Update_Khoa(maKhoa, tenKhoa);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_Khoa(string maKhoa)
        {
            try
            {
                return db.Delete_Khoa(maKhoa);
            }
            catch
            {
                return 0;
            }
        }
        public Khoa Get_Khoa(string MaKhoa)
        {
            return db.Khoas.FirstOrDefault(x => x.MaKhoa == MaKhoa);
        }
        public List<Khoa> Select_Khoa()
        {
            return db.Khoas.ToList();
        }
    }
}
