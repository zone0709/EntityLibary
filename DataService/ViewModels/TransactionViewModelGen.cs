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
    
    public partial class TransactionViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.Transaction>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual int AccountId { get; set; }
    			public virtual decimal Amount { get; set; }
    			public virtual string CurrencyCode { get; set; }
    			public virtual Nullable<decimal> FCAmount { get; set; }
    			public virtual System.DateTime Date { get; set; }
    			public virtual string Notes { get; set; }
    			public virtual bool IsIncreaseTransaction { get; set; }
    			public virtual int Status { get; set; }
    			public virtual int StoreId { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual string UserId { get; set; }
    			public virtual int TransactionType { get; set; }
    	
    	public TransactionViewModel() : base() { }
    	public TransactionViewModel(DataService.Models.Entities.Transaction entity) : base(entity) { }
    
    }
}
