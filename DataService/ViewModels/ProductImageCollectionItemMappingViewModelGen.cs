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
    
    public partial class ProductImageCollectionItemMappingViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.ProductImageCollectionItemMapping>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual int ImageCollectionId { get; set; }
    			public virtual string Title { get; set; }
    			public virtual string ImageUrl { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual int Position { get; set; }
    	
    	public ProductImageCollectionItemMappingViewModel() : base() { }
    	public ProductImageCollectionItemMappingViewModel(DataService.Models.Entities.ProductImageCollectionItemMapping entity) : base(entity) { }
    
    }
}