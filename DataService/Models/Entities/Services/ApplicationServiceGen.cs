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
    
    public partial interface IApplicationService : DataService.BaseConnect.IBaseService<Application, ApplicationViewModel>
    {
    }
    
    public partial class ApplicationService : DataService.BaseConnect.BaseService<Application, ApplicationViewModel>, IApplicationService
    {
         public ApplicationService()
         {
         }
        public ApplicationService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IApplicationRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
