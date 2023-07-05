using QuanLyThuVien_WF.BLL;
using QuanLyThuVien_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.Controller
{
    internal class Quyen_Controller
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public int Insert_Quyen(DtoQuyen dtoQuyen)
        {
            try
            {
                return db.Insert_Quyen(dtoQuyen.MaQuyen, dtoQuyen.XemSach, dtoQuyen.SuaSach, dtoQuyen.XoaSach, dtoQuyen.ThemSach, dtoQuyen.ThemNguoiDung, dtoQuyen.XemNguoiDung, dtoQuyen.SuaNguoiDung, dtoQuyen.XoaNguoiDung, dtoQuyen.XoaMuonTra, dtoQuyen.ThemMuonTra, dtoQuyen.SuaMuonTra, dtoQuyen.XoaMuonTra);
            }
            catch
            {
                return 0;
            }
        }
        //public int Delete_CS(string macs)
        //{
        //    try
        //    {
        //        return db.Delete_CS(macs);
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

        public object Select_Quyen()
        { return db.Select_Quyen(); }
        public Quyen Get_Quyen(string MaQuyen) => db.Quyens.Where(x => x.MaQuyen == MaQuyen).FirstOrDefault();
    }
}
