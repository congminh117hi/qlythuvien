using System;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    class TuaSach_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Them_TuaSach(string mats, string tents, Nullable<int> namxb, string theloai, string manxb, string make, Nullable<int> soluong, string matg, Nullable<int> sotrang)
        {
            try
            {
                return db.Them_TS_V(mats,tents,namxb,theloai,manxb,make,soluong,matg,sotrang);
            }
            catch
            {
                return 0;
            }
        }
        public int Sua_TuaSach(string mats, string tents, Nullable<int> namxb, string theloai, string manxb, string make, Nullable<int> soluong, string matg, Nullable<int> sotrang)
        {
            try
            {
                return db.CapNhat_TS_V(mats, tents, namxb, theloai, manxb, make, soluong, matg, sotrang);
            }
            catch
            {
                return 0;
            }
        }
        public int Xoa_TuaSach(string mats)
        {
            try
            {
                return db.Delete_TS(mats);
            }
            catch
            {
                return 0;
            }
        }
        public Object SelectTS()
        {return db.Select_TS();}

        public Object NXB()
        { return db.Cbb_NXB();}
        public Object TacGia()
        {  return db.Cbb_TacGia();}

    }
}
