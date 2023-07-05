using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Office.Utils;
using QuanLyThuVien_WF.BLL;
using QuanLyThuVien_WF.Models;

namespace QuanLyThuVien_WF.Controller
{
    public class ThongKe_Controller
    {
        static QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public static Object DaMuon()
        { return db.DaMuon(); }
        public static Object CM()
        { return db.ChuaMuon(); }
        //===============================
        public List<DtoThongKe> ThongKeMuonSach(DateTime from, DateTime to, int trangthai)
        {

            List<DtoThongKe> result = new List<DtoThongKe>();
            PhieuMuon_Controller phieuMuon_Controller = new PhieuMuon_Controller();
            List<PhieuMuon> phieuMuonSach_ = db.PhieuMuons
                        .Where(x=>x.NgayMuon>=from && x.NgayMuon<=to).ToList();
            DateTime dateTime = DateTime.Now;
            foreach (PhieuMuon item in phieuMuonSach_)
            {
                if (dateTime!=item.NgayMuon)
                {
                    dateTime = item.NgayMuon;
                }
                ChiTietMuon chiTietMuon = db.ChiTietMuons.FirstOrDefault(x=>x.MaPM==item.MaPM);
                CuonSach cuonSach = db.CuonSaches.FirstOrDefault(x => x.MaCS == chiTietMuon.MaCS);
                TuaSach tuaSach = db.TuaSaches.FirstOrDefault(x => x.MaTS == cuonSach.MaTS );
                string tinhtrang = DateTime.Compare(DateTime.Today, item.NgayTra) < 0 ? "Chưa Trả" : "Đã Trả";
                if ((trangthai==1 && tinhtrang =="Chưa Trả")||(trangthai==2 && tinhtrang=="Đã Trả"))
                {
                    continue;
                }
                DtoThongKe dtoThongKe = result.Where(x => x.MaCS == dateTime.ToString("dd/MM/yyyy")).FirstOrDefault();
                if(dtoThongKe==null)
                {
                    dtoThongKe = new DtoThongKe
                    {
                        MaCS = item.NgayMuon.ToString("dd/MM/yyyy"),
                        TinhTrang = "",
                        NgayTra = "",
                        TuaCS = "",
                        ChiTiets = new List<DtoThongKe>()
                    };
                    result.Add(dtoThongKe);
                }
                DtoThongKe dtoThongKeChiTiet = new DtoThongKe
                {
                    MaCS = cuonSach.MaCS,
                    TuaCS = tuaSach.TenTS,
                    MaDG = item.MaDG,
                    NgayTra = item.NgayTra.ToString("dd/MM/yyyy"),
                    TinhTrang = tinhtrang
                };
                dtoThongKe.ChiTiets.Add(dtoThongKeChiTiet);
            }
            return result;
        }
        public List<DtoChuaMuon> ThongKeChuaMuon()
        {
            List<DtoChuaMuon> result = new List<DtoChuaMuon>();
            List<DtoChuaMuon> data1 = new List<DtoChuaMuon>();
            List<DtoChuaMuon>  data = db.vw_ThongKeChuaMuon.Select(x=>new DtoChuaMuon
            {
                MaCS=x.MaCS,
                MaTS=x.MaTS,
                SoLanMuon = db.vw_ThongKeChuaMuon.Count(y=>y.MaCS==x.MaCS && x.MaPM!=null),
                TenSach = db.TuaSaches.FirstOrDefault(ts=>ts.MaTS==x.MaTS).TenTS
            }).ToList();
            foreach(DtoChuaMuon t in data)
            {
                bool trung = false;
                foreach (DtoChuaMuon item in data1)
                {
                    if (item.MaCS==t.MaCS)
                    {
                        trung = true;
                        break;
                    }
                }
                if(!trung)
                {
                    data1.Add(t);
                }
            }    
            foreach(DtoChuaMuon t in data1)
            {
                DtoChuaMuon chuamuon = result.FirstOrDefault(x => x.TenSach == t.TenSach);
                if (chuamuon==null)
                {
                    chuamuon = new DtoChuaMuon()
                    {
                        MaCS = t.MaTS,
                        TenSach = t.TenSach,
                        ChiTiets = new List<DtoChuaMuon> { t}
                    };
                    result.Add(chuamuon);
                }
                else
                    chuamuon.ChiTiets.Add(t);
            }    
            return result;
        }
    }
}
