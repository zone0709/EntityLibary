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
    
    public partial class StoreUserViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.StoreUser>
    {
    	
    			public virtual string Username { get; set; }
    			public virtual int StoreId { get; set; }
    	
    	public StoreUserViewModel() : base() { }
    	public StoreUserViewModel(DataService.Models.Entities.StoreUser entity) : base(entity) { }
    
    }
}