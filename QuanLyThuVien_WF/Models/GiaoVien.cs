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
    
    public partial class GiaoVien
    {
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaKhoa { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    
        public virtual Khoa Khoa { get; set; }
    }
}