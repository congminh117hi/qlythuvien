using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.BLL
{
    public class DtoThongKe
    {
        public string MaCS { get; set; }//Ngày mượn
        public string TuaCS { get; set; }
        public string MaDG { get; set; }
        public string NgayTra { get; set; }
        public string TinhTrang { get; set; }
        public List<DtoThongKe> ChiTiets { get; set; }
    }
}
