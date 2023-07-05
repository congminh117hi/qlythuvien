using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class PhanQuyen_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_PQ(string maNguoiDung, string maQuyen)
        {
            try
            {
                return db.Insert_PhanQuyen( maNguoiDung, maQuyen);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_PQ(string maQuyen, string maNguoiDung)
        {
            try
            {
                return db.Delete_PQ(maQuyen, maNguoiDung);
            }
            catch
            {
                return 0;
            }
        }
        public PhanQuyen Get_PQ(string maNguoiDung)
        {
            
            return db.PhanQuyens.Where(x=>x.MaNguoiDung==maNguoiDung).FirstOrDefault();
        }
        public object Select_PQ()
        { return db.Select_PQ(); }
    }
}
