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
    
    public partial class PaySlipItemViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.PaySlipItem>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual Nullable<int> PaySlipId { get; set; }
    			public virtual Nullable<int> PayrollDetailId { get; set; }
    			public virtual Nullable<double> Value { get; set; }
    			public virtual bool Active { get; set; }
    	
    	public PaySlipItemViewModel() : base() { }
    	public PaySlipItemViewModel(DataService.Models.Entities.PaySlipItem entity) : base(entity) { }
    
    }
}