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
    
    public partial class Quyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quyen()
        {
            this.PhanQuyens = new HashSet<PhanQuyen>();
        }
    
        public string MaQuyen { get; set; }
        public Nullable<bool> XemSach { get; set; }
        public Nullable<bool> SuaSach { get; set; }
        public Nullable<bool> XoaSach { get; set; }
        public Nullable<bool> ThemSach { get; set; }
        public Nullable<bool> ThemNguoiDung { get; set; }
        public Nullable<bool> XemNguoiDung { get; set; }
        public Nullable<bool> SuaNguoiDung { get; set; }
        public Nullable<bool> XoaNguoiDung { get; set; }
        public Nullable<bool> XemMuonTra { get; set; }
        public Nullable<bool> ThemMuonTra { get; set; }
        public Nullable<bool> SuaMuonTra { get; set; }
        public Nullable<bool> XoaMuonTra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanQuyen> PhanQuyens { get; set; }
    }
}