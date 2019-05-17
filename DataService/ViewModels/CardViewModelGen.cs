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
    
    public partial class CardViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.Card>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual int IdCardType { get; set; }
    			public virtual string CardCode { get; set; }
    			public virtual System.DateTime CreatedTime { get; set; }
    			public virtual Nullable<System.DateTime> ExpiryDate { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual int MembershipId { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual string CreateBy { get; set; }
    			public virtual Nullable<bool> IsSample { get; set; }
    	
    	public CardViewModel() : base() { }
    	public CardViewModel(DataService.Models.Entities.Card entity) : base(entity) { }
    
    }
}
