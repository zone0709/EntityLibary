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
    
    public partial class CostInventoryMappingViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.CostInventoryMapping>
    {
    	
    			public virtual int CostID { get; set; }
    			public virtual int ReceiptID { get; set; }
    			public virtual Nullable<int> StoreId { get; set; }
    			public virtual Nullable<int> ProviderID { get; set; }
    	
    	public CostInventoryMappingViewModel() : base() { }
    	public CostInventoryMappingViewModel(DataService.Models.Entities.CostInventoryMapping entity) : base(entity) { }
    
    }
}