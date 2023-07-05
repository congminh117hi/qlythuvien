using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_WF.BLL
{
    public class DtoQuyen
    {
        public string MaQuyen { get; set; }
        public bool XemSach { get; set; }
        public bool ThemSach { get; set; }
        public bool SuaSach { get; set; }
        public bool XoaSach { get; set; }
        public bool XemNguoiDung { get; set; }
        public bool SuaNguoiDung { get; set; }
        public bool ThemNguoiDung { get; set; }
        public bool XoaNguoiDung { get; set; }
        public bool XemMuonTra { get; set; }
        public bool ThemMuonTra { get; set; }
        public bool XoaMuonTra { get; set; }
        public bool SuaMuonTra { get; set; }
    }
}
