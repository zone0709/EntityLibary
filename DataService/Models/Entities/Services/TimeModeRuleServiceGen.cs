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
    
    public partial interface ITimeModeRuleService : DataService.BaseConnect.IBaseService<TimeModeRule, TimeModeRuleViewModel>
    {
    }
    
    public partial class TimeModeRuleService : DataService.BaseConnect.BaseService<TimeModeRule, TimeModeRuleViewModel>, ITimeModeRuleService
    {
         public TimeModeRuleService()
         {
         }
        public TimeModeRuleService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.ITimeModeRuleRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}