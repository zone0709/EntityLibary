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
    
    public partial class PaySlipViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.PaySlip>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual Nullable<int> PayrollPeriodId { get; set; }
    			public virtual Nullable<int> EmployeeId { get; set; }
    			public virtual Nullable<int> TemplateDetailMappingId { get; set; }
    			public virtual Nullable<System.DateTime> FromDate { get; set; }
    			public virtual Nullable<System.DateTime> ToDate { get; set; }
    			public virtual Nullable<double> FinalPaid { get; set; }
    			public virtual bool Active { get; set; }
    	
    	public PaySlipViewModel() : base() { }
    	public PaySlipViewModel(DataService.Models.Entities.PaySlip entity) : base(entity) { }
    
    }
}
