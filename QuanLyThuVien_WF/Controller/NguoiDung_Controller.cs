using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class NguoiDung_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_ND(string maNguoiDung, string maTT, string matkhau)
        {
            try
            {
                return db.Insert_Nguoidung(maNguoiDung, maTT, matkhau);
            }
            catch
            {
                return 0;
            }
        }
        public int Delete_ND(string maNguoiDung)
        {
            try
            {
                return db.Delete_Nguoidung(maNguoiDung);
            }
            catch
            {
                return 0;
            }
            
        }
        public Object Select_NguoiDung()
        { return db.Select_Nguoidung(); }
        public NguoiDung Get_NguoiDung(string maNguoiDung) => db.NguoiDungs.Where(x=>x.MaNguoiDung==maNguoiDung).FirstOrDefault();

    }
}
