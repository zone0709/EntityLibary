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
    
    public partial class UserAccessViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.UserAccess>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual Nullable<int> UserAccess_CampaignId { get; set; }
    	
    	public UserAccessViewModel() : base() { }
    	public UserAccessViewModel(DataService.Models.Entities.UserAccess entity) : base(entity) { }
    
    }
}
