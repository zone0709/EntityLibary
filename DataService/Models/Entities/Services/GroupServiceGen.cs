//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.Models.Entities.Services
{
    using System;
    using System.Collections.Generic;
    using DataService.ViewModels;
    
    public partial interface IGroupService : DataService.BaseConnect.IBaseService<Group, GroupViewModel>
    {
    }
    
    public partial class GroupService : DataService.BaseConnect.BaseService<Group, GroupViewModel>, IGroupService
    {
         public GroupService()
         {
         }
        public GroupService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IGroupRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
