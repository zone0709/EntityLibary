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
    
    public partial class EmployeeGroupViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.EmployeeGroup>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string CodeGroup { get; set; }
    			public virtual string NameGroup { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual bool Active { get; set; }
    			public virtual Nullable<System.TimeSpan> ExpandTime { get; set; }
    			public virtual Nullable<int> GroupPolicy { get; set; }
    			public virtual Nullable<int> GroupSecurity { get; set; }
    	
    	public EmployeeGroupViewModel() : base() { }
    	public EmployeeGroupViewModel(DataService.Models.Entities.EmployeeGroup entity) : base(entity) { }
    
    }
}