//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestrurentDashboard
    {
        public int Id { get; set; }
        public int DId { get; set; }
        public int RId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Restrurant Restrurant { get; set; }
        public virtual Dashboard Dashboard { get; set; }
    }
}
