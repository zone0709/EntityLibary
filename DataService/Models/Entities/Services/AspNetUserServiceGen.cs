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
    
    public partial interface IAspNetUserService : DataService.BaseConnect.IBaseService<AspNetUser, AspNetUserViewModel>
    {
    }
    
    public partial class AspNetUserService : DataService.BaseConnect.BaseService<AspNetUser, AspNetUserViewModel>, IAspNetUserService
    {
         public AspNetUserService()
         {
         }
        public AspNetUserService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IAspNetUserRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
