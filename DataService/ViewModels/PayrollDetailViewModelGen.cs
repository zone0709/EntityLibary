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
    
    public partial class PayrollDetailViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.PayrollDetail>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual Nullable<double> Value { get; set; }
    			public virtual Nullable<int> PayrollCategoryId { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual int BrandId { get; set; }
    	
    	public PayrollDetailViewModel() : base() { }
    	public PayrollDetailViewModel(DataService.Models.Entities.PayrollDetail entity) : base(entity) { }
    
    }
}
