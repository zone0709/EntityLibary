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
    
    public partial interface ICouponCampaignService : DataService.BaseConnect.IBaseService<CouponCampaign, CouponCampaignViewModel>
    {
    }
    
    public partial class CouponCampaignService : DataService.BaseConnect.BaseService<CouponCampaign, CouponCampaignViewModel>, ICouponCampaignService
    {
         public CouponCampaignService()
         {
         }
        public CouponCampaignService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.ICouponCampaignRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}