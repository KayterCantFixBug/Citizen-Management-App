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
    
    public partial class KhaiSinh
    {
        public int MaCD { get; set; }
        public int MaKH { get; set; }
        public System.DateTime NgayKhai { get; set; }
    
        public virtual CongDan CongDan { get; set; }
        public virtual KetHon KetHon { get; set; }
    }
}