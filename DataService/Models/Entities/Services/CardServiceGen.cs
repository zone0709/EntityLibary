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
    
    public partial interface ICardService : DataService.BaseConnect.IBaseService<Card, CardViewModel>
    {
    }
    
    public partial class CardService : DataService.BaseConnect.BaseService<Card, CardViewModel>, ICardService
    {
         public CardService()
         {
         }
        public CardService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.ICardRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}