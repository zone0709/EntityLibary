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
    
    
    public partial interface IRoomRepository : DataService.BaseConnect.IBaseRepository<Room>
    {
    }
    
    public partial class RoomRepository : DataService.BaseConnect.BaseRepository<Room>, IRoomRepository
    {
    	public RoomRepository(System.Data.Entity.DbContext dbContext) : base(dbContext)
    	{
    	}
    }
}