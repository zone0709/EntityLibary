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
    
    public partial interface IPosFileService : DataService.BaseConnect.IBaseService<PosFile, PosFileViewModel>
    {
    }
    
    public partial class PosFileService : DataService.BaseConnect.BaseService<PosFile, PosFileViewModel>, IPosFileService
    {
         public PosFileService()
         {
         }
        public PosFileService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IPosFileRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
