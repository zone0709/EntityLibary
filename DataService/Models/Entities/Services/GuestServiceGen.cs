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
    
    public partial interface IGuestService : DataService.BaseConnect.IBaseService<Guest, GuestViewModel>
    {
    }
    
    public partial class GuestService : DataService.BaseConnect.BaseService<Guest, GuestViewModel>, IGuestService
    {
         public GuestService()
         {
         }
        public GuestService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IGuestRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}