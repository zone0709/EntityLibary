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
    
    public partial interface IOrderFeeItemService : DataService.BaseConnect.IBaseService<OrderFeeItem, OrderFeeItemViewModel>
    {
    }
    
    public partial class OrderFeeItemService : DataService.BaseConnect.BaseService<OrderFeeItem, OrderFeeItemViewModel>, IOrderFeeItemService
    {
         public OrderFeeItemService()
         {
         }
        public OrderFeeItemService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IOrderFeeItemRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}