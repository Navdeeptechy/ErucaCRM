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
    
    public partial class TaskStatu
    {
        public TaskStatu()
        {
            this.TaskItems = new HashSet<TaskItem>();
        }
    
        public int TaskStatusId { get; set; }
        public string StatusName { get; set; }
    
        public virtual ICollection<TaskItem> TaskItems { get; set; }
    }
}
