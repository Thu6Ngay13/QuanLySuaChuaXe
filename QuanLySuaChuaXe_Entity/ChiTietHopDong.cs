//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySuaChuaXe_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHopDong
    {
        public string ID_Tho { get; set; }
        public string ID_CongViec { get; set; }
        public string ID_HopDong { get; set; }
    
        public virtual CongViec CongViec { get; set; }
        public virtual HopDong HopDong { get; set; }
        public virtual Tho Tho { get; set; }
    }
}