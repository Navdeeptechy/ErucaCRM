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
    
    public partial class LeadTag
    {
        public int LeadTagId { get; set; }
        public int LeadId { get; set; }
        public int TagId { get; set; }
    
        public virtual Tag Tag { get; set; }
        public virtual Lead Lead { get; set; }
    }
}