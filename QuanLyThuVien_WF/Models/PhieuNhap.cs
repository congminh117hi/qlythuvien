//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien_WF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            this.ChiTietNhaps = new HashSet<ChiTietNhap>();
        }
    
        public string MaPN { get; set; }
        public System.DateTime NgayLap { get; set; }
        public string MaTT { get; set; }
        public string MaNCC { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual NCC NCC { get; set; }
        public virtual ThuThu ThuThu { get; set; }
    }
}
