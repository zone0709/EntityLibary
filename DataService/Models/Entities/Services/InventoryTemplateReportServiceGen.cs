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
    
    public partial interface IInventoryTemplateReportService : DataService.BaseConnect.IBaseService<InventoryTemplateReport, InventoryTemplateReportViewModel>
    {
    }
    
    public partial class InventoryTemplateReportService : DataService.BaseConnect.BaseService<InventoryTemplateReport, InventoryTemplateReportViewModel>, IInventoryTemplateReportService
    {
         public InventoryTemplateReportService()
         {
         }
        public InventoryTemplateReportService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IInventoryTemplateReportRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}