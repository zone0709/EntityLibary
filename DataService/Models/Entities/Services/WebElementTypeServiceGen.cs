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
    
    public partial interface IWebElementTypeService : DataService.BaseConnect.IBaseService<WebElementType, WebElementTypeViewModel>
    {
    }
    
    public partial class WebElementTypeService : DataService.BaseConnect.BaseService<WebElementType, WebElementTypeViewModel>, IWebElementTypeService
    {
         public WebElementTypeService()
         {
         }
        public WebElementTypeService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IWebElementTypeRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}