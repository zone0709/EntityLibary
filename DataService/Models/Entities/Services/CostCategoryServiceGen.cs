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
    
    public partial interface ICostCategoryService : DataService.BaseConnect.IBaseService<CostCategory, CostCategoryViewModel>
    {
    }
    
    public partial class CostCategoryService : DataService.BaseConnect.BaseService<CostCategory, CostCategoryViewModel>, ICostCategoryService
    {
         public CostCategoryService()
         {
         }
        public CostCategoryService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.ICostCategoryRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}