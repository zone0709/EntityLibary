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
    
    public partial interface IThemeService : DataService.BaseConnect.IBaseService<Theme, ThemeViewModel>
    {
    }
    
    public partial class ThemeService : DataService.BaseConnect.BaseService<Theme, ThemeViewModel>, IThemeService
    {
         public ThemeService()
         {
         }
        public ThemeService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IThemeRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}