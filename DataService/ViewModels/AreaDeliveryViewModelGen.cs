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
    
    public partial class AreaDeliveryViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.AreaDelivery>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string AreaName { get; set; }
    			public virtual int AreaType { get; set; }
    			public virtual decimal PriceDelivery { get; set; }
    			public virtual Nullable<int> AreaID { get; set; }
    	
    	public AreaDeliveryViewModel() : base() { }
    	public AreaDeliveryViewModel(DataService.Models.Entities.AreaDelivery entity) : base(entity) { }
    
    }
}
