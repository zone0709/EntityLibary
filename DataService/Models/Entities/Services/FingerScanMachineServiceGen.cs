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
    
    public partial interface IFingerScanMachineService : DataService.BaseConnect.IBaseService<FingerScanMachine, FingerScanMachineViewModel>
    {
    }
    
    public partial class FingerScanMachineService : DataService.BaseConnect.BaseService<FingerScanMachine, FingerScanMachineViewModel>, IFingerScanMachineService
    {
         public FingerScanMachineService()
         {
         }
        public FingerScanMachineService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IFingerScanMachineRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}