using System;
using QuanLyThuVien_WF.Models;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Data.ODataLinq.Helpers;
using System.Linq;

namespace QuanLyThuVien_WF.Controller
{
   class ThuThu_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int THEM_THUTHU(string matt, string tentt, string gioitinhtt, DateTime ngaysinhtt, string diachitt, string sdttt, string chucvu)
        {
            try
            {
              return db.Insert_TT(matt,tentt,gioitinhtt,ngaysinhtt,diachitt,sdttt,chucvu);
            }
            catch
            {
                return 0;
            }
        }

        public int UPDATE_THUTHU(string matt, string tentt, string gioitinhtt, DateTime ngaysinhtt, string diachitt, string sdttt, string chucvu)
        {
            try
            {
                return db.Update_TT(matt, tentt, gioitinhtt, ngaysinhtt, diachitt, sdttt, chucvu);
            }
            catch
            {
                return 0;
            }
        }

        public int XOA_THUTHU(string matt)
        {
            try
            {
                return db.Delete_TT(matt);
            }
            catch
            {
                return 0;
            }
        }

        public Object Select_ThuThu()
        {
            return db.Select_TT();
        }
        public ThuThu Get_ThuThu(string matt)
        {
            return db.ThuThus.Where(x=>x.MaTT==matt).FirstOrDefault();
        }
    }
}
