using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class GiaoVien_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_GiaoVien(string maGV, string tenGV, string maKhoa, string gioitinhGV, DateTime ngaysinhGV, string diachiGV, string sdtGV)
        {
            try
            {
                return db.Insert_GV(maGV, tenGV, sdtGV, diachiGV, maKhoa, ngaysinhGV, gioitinhGV);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_GiaoVien(string maGV, string tenGV, string maKhoa, string gioitinhGV, DateTime ngaysinhGV, string diachiGV, string sdtGV)
        {
            try
            {
                return db.Update_GV(maGV, tenGV, maKhoa, sdtGV, diachiGV, ngaysinhGV, gioitinhGV);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_GiaoVien(string maGV)
        {
            try
            {
                return db.Delete_GV(maGV);
            }
            catch
            {
                return 0;
            }
        }
        public GiaoVien Get_GV(string MaGV)
        {
            return db.GiaoViens.FirstOrDefault(x => x.MaGV == MaGV);
        }
        public List<GiaoVien> Select_GiaoVien()
        {
            return db.GiaoViens.ToList();
        }
    }
}
