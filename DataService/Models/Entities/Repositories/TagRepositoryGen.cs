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
    
    
    public partial interface ITagRepository : DataService.BaseConnect.IBaseRepository<Tag>
    {
    }
    
    public partial class TagRepository : DataService.BaseConnect.BaseRepository<Tag>, ITagRepository
    {
    	public TagRepository(System.Data.Entity.DbContext dbContext) : base(dbContext)
    	{
    	}
    }
}