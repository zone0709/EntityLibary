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
    
    public partial interface ICouponProviderService : DataService.BaseConnect.IBaseService<CouponProvider, CouponProviderViewModel>
    {
    }
    
    public partial class CouponProviderService : DataService.BaseConnect.BaseService<CouponProvider, CouponProviderViewModel>, ICouponProviderService
    {
         public CouponProviderService()
         {
         }
        public CouponProviderService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.ICouponProviderRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}