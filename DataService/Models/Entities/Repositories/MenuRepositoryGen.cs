//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.Models.Entities.Repositories
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IMenuRepository : DataService.BaseConnect.IBaseRepository<Menu>
    {
    }
    
    public partial class MenuRepository : DataService.BaseConnect.BaseRepository<Menu>, IMenuRepository
    {
    	public MenuRepository(System.Data.Entity.DbContext dbContext) : base(dbContext)
    	{
    	}
    }
}