//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErucaCRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public Rating()
        {
            this.Stages = new HashSet<Stage>();
            this.Leads = new HashSet<Lead>();
            this.LeadAudits = new HashSet<LeadAudit>();
        }
    
        public int RatingId { get; set; }
        public Nullable<decimal> ExpectedRevenuePercentage { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool RecordDeleted { get; set; }
        public Nullable<int> IsClosedWin { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public int RatingConstant { get; set; }
        public string Icons { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<LeadAudit> LeadAudits { get; set; }
    }
}