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
    
    public partial class SalaryRuleViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.SalaryRule>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual Nullable<int> TimeModeRuleId { get; set; }
    			public virtual double MinTimeDuration { get; set; }
    			public virtual double MaxTimeDuration { get; set; }
    			public virtual Nullable<double> Value { get; set; }
    			public virtual Nullable<double> Rate { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual bool Active { get; set; }
    	
    	public SalaryRuleViewModel() : base() { }
    	public SalaryRuleViewModel(DataService.Models.Entities.SalaryRule entity) : base(entity) { }
    
    }
}