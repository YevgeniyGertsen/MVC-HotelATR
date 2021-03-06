//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAtr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int RoomId { get; set; }
        public int RoomTypeId { get; set; }
        public Nullable<decimal> Square { get; set; }
        public Nullable<int> MaxPersons { get; set; }
        public bool IsFreeWifi { get; set; }
        public bool IsPrivateBalcony { get; set; }
        public bool IsFullAC { get; set; }
        public int Floor { get; set; }
        public bool HasTV { get; set; }
        public bool IsBeachView { get; set; }
    
        public virtual RoomType RoomType { get; set; }
    }
}
