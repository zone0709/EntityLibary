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
    
    public partial interface IBlogCategoryService : DataService.BaseConnect.IBaseService<BlogCategory, BlogCategoryViewModel>
    {
    }
    
    public partial class BlogCategoryService : DataService.BaseConnect.BaseService<BlogCategory, BlogCategoryViewModel>, IBlogCategoryService
    {
         public BlogCategoryService()
         {
         }
        public BlogCategoryService(DataService.BaseConnect.IUnitOfWork unitOfWork, Repositories.IBlogCategoryRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}