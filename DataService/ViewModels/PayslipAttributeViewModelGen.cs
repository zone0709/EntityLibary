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
    
    public partial class PayslipAttributeViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.PayslipAttribute>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Name { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual int BrandId { get; set; }
    	
    	public PayslipAttributeViewModel() : base() { }
    	public PayslipAttributeViewModel(DataService.Models.Entities.PayslipAttribute entity) : base(entity) { }
    
    }
}