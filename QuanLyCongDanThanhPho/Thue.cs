//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCongDanThanhPho
{
    using System;
    using System.Collections.Generic;
    
    public partial class Thue
    {
        public int MaThue { get; set; }
        public string TenThue { get; set; }
        public double MucThue { get; set; }
        public string CCCD { get; set; }
        public double ThuNhap { get; set; }
        public System.DateTime Ngay { get; set; }
    
        public virtual CanCuocCongDan CanCuocCongDan { get; set; }
    }
}
