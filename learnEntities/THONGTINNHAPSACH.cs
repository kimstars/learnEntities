//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace learnEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONGTINNHAPSACH
    {
        public string MaPhieuNhap { get; set; }
        public string MaDauSach { get; set; }
        public int SoLuongSach { get; set; }
    
        public virtual DAUSACH DAUSACH { get; set; }
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}
