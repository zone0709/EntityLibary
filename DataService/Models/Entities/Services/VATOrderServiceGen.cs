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
    
    public partial interface IVATOrderService : DataService.BaseConnect.IBaseService<VATOrder, VATOrderViewModel>
    {
    }
    
    public partial class VATOrderService : DataService.BaseConnect.BaseService<VATOrder, VATOrderViewModel>, IVATOrderService
    {
         public VATOrderService()
         {
         }
        public VATOrderService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IVATOrderRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
