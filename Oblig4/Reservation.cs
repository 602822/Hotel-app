//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oblig4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int id { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int Person { get; set; }
        public int Room { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Room Room1 { get; set; }
    }
}
