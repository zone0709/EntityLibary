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
    
    public partial class TimeFrameViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.TimeFrame>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual System.TimeSpan StartTime { get; set; }
    			public virtual System.TimeSpan EndTime { get; set; }
    			public virtual System.TimeSpan Duration { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual Nullable<int> EmployeeGroupId { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual System.TimeSpan BreakTime { get; set; }
    			public virtual Nullable<bool> IsOverTime { get; set; }
    			public virtual int InMode { get; set; }
    			public virtual int OutMode { get; set; }
    			public virtual int BreakCount { get; set; }
    			public virtual Nullable<System.TimeSpan> CheckInExpandTime { get; set; }
    			public virtual Nullable<System.TimeSpan> CheckOutExpandTime { get; set; }
    			public virtual Nullable<int> StoreFilter { get; set; }
    			public virtual Nullable<System.TimeSpan> ComeLateExpandTime { get; set; }
    			public virtual Nullable<System.TimeSpan> LeaveEarlyExpandTime { get; set; }
    	
    	public TimeFrameViewModel() : base() { }
    	public TimeFrameViewModel(DataService.Models.Entities.TimeFrame entity) : base(entity) { }
    
    }
}