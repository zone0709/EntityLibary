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
    
    public partial interface IPaySlipItemService : DataService.BaseConnect.IBaseService<PaySlipItem, PaySlipItemViewModel>
    {
    }
    
    public partial class PaySlipItemService : DataService.BaseConnect.BaseService<PaySlipItem, PaySlipItemViewModel>, IPaySlipItemService
    {
         public PaySlipItemService()
         {
         }
        public PaySlipItemService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IPaySlipItemRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}