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
    
    public partial interface IPartnerService : DataService.BaseConnect.IBaseService<Partner, PartnerViewModel>
    {
    }
    
    public partial class PartnerService : DataService.BaseConnect.BaseService<Partner, PartnerViewModel>, IPartnerService
    {
         public PartnerService()
         {
         }
        public PartnerService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IPartnerRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}