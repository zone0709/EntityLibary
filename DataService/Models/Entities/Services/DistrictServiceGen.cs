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
    
    public partial interface IDistrictService : DataService.BaseConnect.IBaseService<District, DistrictViewModel>
    {
    }
    
    public partial class DistrictService : DataService.BaseConnect.BaseService<District, DistrictViewModel>, IDistrictService
    {
         public DistrictService()
         {
         }
        public DistrictService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IDistrictRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}