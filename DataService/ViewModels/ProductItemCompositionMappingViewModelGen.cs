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
    
    public partial class ProductItemCompositionMappingViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.ProductItemCompositionMapping>
    {
    	
    			public virtual int ProducID { get; set; }
    			public virtual int ItemID { get; set; }
    			public virtual double Quantity { get; set; }
    	
    	public ProductItemCompositionMappingViewModel() : base() { }
    	public ProductItemCompositionMappingViewModel(DataService.Models.Entities.ProductItemCompositionMapping entity) : base(entity) { }
    
    }
}
