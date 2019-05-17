//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskDetailViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.TaskDetail>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Subject { get; set; }
    			public virtual string Description { get; set; }
    			public virtual System.DateTime StartTime { get; set; }
    			public virtual System.DateTime EndTime { get; set; }
    			public virtual Nullable<int> Status { get; set; }
    			public virtual System.DateTime CreateTime { get; set; }
    			public virtual string CreatedBy { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual int StoreId { get; set; }
    			public virtual Nullable<System.TimeSpan> Duration { get; set; }
    			public virtual Nullable<int> EmployeeId { get; set; }
    			public virtual string ApprovedBy { get; set; }
    	
    	public TaskDetailViewModel() : base() { }
    	public TaskDetailViewModel(DataService.Models.Entities.TaskDetail entity) : base(entity) { }
    
    }
}