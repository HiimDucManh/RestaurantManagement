//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKROOM
    {
        public int B_ID { get; set; }
        public string CUS_ID { get; set; }
        public string CUS_NAME { get; set; }
        public string RO_ID { get; set; }
        public string SER_ID { get; set; }
        public Nullable<System.DateTime> DAY_ARRIVAL { get; set; }
        public Nullable<System.DateTime> DAY_LEFT { get; set; }
        public Nullable<System.DateTime> DAY_BOOK { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual CUSTOMER CUSTOMER1 { get; set; }
        public virtual ROOM ROOM { get; set; }
        public virtual ROOM ROOM1 { get; set; }
        public virtual HOTELSERVICE HOTELSERVICE { get; set; }
    }
}
