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
    
    public partial class CouponViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.Coupon>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual Nullable<int> CampaginId { get; set; }
    			public virtual string SerialNumber { get; set; }
    			public virtual int Status { get; set; }
    			public virtual bool IsActive { get; set; }
    			public virtual Nullable<int> StoreId { get; set; }
    			public virtual Nullable<System.DateTime> DateUse { get; set; }
    			public virtual string ImageUrl { get; set; }
    	
    	public CouponViewModel() : base() { }
    	public CouponViewModel(DataService.Models.Entities.Coupon entity) : base(entity) { }
    
    }
}