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
    
    public partial class ProductImageCollectionViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.ProductImageCollection>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual int StoreId { get; set; }
    			public virtual string Name { get; set; }
    			public virtual bool Active { get; set; }
    	
    	public ProductImageCollectionViewModel() : base() { }
    	public ProductImageCollectionViewModel(DataService.Models.Entities.ProductImageCollection entity) : base(entity) { }
    
    }
}