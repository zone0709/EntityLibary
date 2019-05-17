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
    
    public partial class RatingViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.Rating>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string UserId { get; set; }
    			public virtual Nullable<int> ProductId { get; set; }
    			public virtual System.DateTime CreateTime { get; set; }
    			public virtual Nullable<int> Star { get; set; }
    			public virtual string ReviewContent { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual string ReviewEmail { get; set; }
    			public virtual string ReviewName { get; set; }
    			public virtual Nullable<bool> Verified { get; set; }
    			public virtual Nullable<int> Rate1 { get; set; }
    			public virtual Nullable<int> Rate2 { get; set; }
    			public virtual Nullable<int> Rate3 { get; set; }
    			public virtual Nullable<int> Rate4 { get; set; }
    			public virtual Nullable<int> Rate5 { get; set; }
    			public virtual Nullable<int> CustomerId { get; set; }
    			public virtual Nullable<int> OrderId { get; set; }
    	
    	public RatingViewModel() : base() { }
    	public RatingViewModel(DataService.Models.Entities.Rating entity) : base(entity) { }
    
    }
}
