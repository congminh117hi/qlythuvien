using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.BLL
{
    public class DtoChuaMuon
    {
        public string MaCS { get; set; }
        public string MaTS { get; set; }
        public string TenSach { get; set; }
        public int SoLanMuon { get; set; }
        public List<DtoChuaMuon> ChiTiets { get; set; }
    }
}
