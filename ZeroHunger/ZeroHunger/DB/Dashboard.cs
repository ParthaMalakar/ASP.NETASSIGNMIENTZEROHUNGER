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
    
    public partial class Dashboard
    {
        public Dashboard()
        {
            this.RestrurentDashboards = new HashSet<RestrurentDashboard>();
        }
    
        public int Id { get; set; }
        public string Collect_Item { get; set; }
        public string Quantity { get; set; }
        public Nullable<int> RID { get; set; }
    
        public virtual ICollection<RestrurentDashboard> RestrurentDashboards { get; set; }
    }
}
