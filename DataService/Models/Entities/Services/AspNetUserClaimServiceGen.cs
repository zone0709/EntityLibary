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
    
    public partial interface IAspNetUserClaimService : DataService.BaseConnect.IBaseService<AspNetUserClaim, AspNetUserClaimViewModel>
    {
    }
    
    public partial class AspNetUserClaimService : DataService.BaseConnect.BaseService<AspNetUserClaim, AspNetUserClaimViewModel>, IAspNetUserClaimService
    {
         public AspNetUserClaimService()
         {
         }
        public AspNetUserClaimService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IAspNetUserClaimRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
