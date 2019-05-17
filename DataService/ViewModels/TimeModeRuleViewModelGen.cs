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
    
    public partial class TimeModeRuleViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.TimeModeRule>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual Nullable<System.TimeSpan> StartHour { get; set; }
    			public virtual Nullable<System.TimeSpan> EndHour { get; set; }
    			public virtual Nullable<double> MinDuration { get; set; }
    			public virtual Nullable<double> MaxDuration { get; set; }
    			public virtual Nullable<int> DayModeId { get; set; }
    			public virtual Nullable<int> TimeModeTypeId { get; set; }
    			public virtual Nullable<double> DefaultRate { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual bool Active { get; set; }
    	
    	public TimeModeRuleViewModel() : base() { }
    	public TimeModeRuleViewModel(DataService.Models.Entities.TimeModeRule entity) : base(entity) { }
    
    }
}
