//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogCategoryViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.BlogCategory>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string Title { get; set; }
    			public virtual string FeedburnerUrl { get; set; }
    			public virtual string PageTitle { get; set; }
    			public virtual string MetaDescription { get; set; }
    			public virtual string UrlHandle { get; set; }
    			public virtual string IsAllowComment { get; set; }
    			public virtual int StoreId { get; set; }
    			public virtual bool IsActive { get; set; }
    			public virtual string Feedburner { get; set; }
    			public virtual int BrandId { get; set; }
    			public virtual Nullable<bool> IsDisplay { get; set; }
    			public virtual Nullable<int> ParentCateId { get; set; }
    			public virtual Nullable<int> Type { get; set; }
    			public virtual Nullable<int> Position { get; set; }
    			public virtual string BlogCateName { get; set; }
    			public virtual string BlogCateName_EN { get; set; }
    			public virtual string PageTitle_EN { get; set; }
    			public virtual string Description { get; set; }
    			public virtual string Description_EN { get; set; }
    			public virtual string SeoName { get; set; }
    			public virtual string SeoKeyword { get; set; }
    			public virtual string SeoDescription { get; set; }
    			public virtual string ImageFontAwsomeCss { get; set; }
    			public virtual Nullable<int> PositionTopicHomePage { get; set; }
    			public virtual string PicUrl { get; set; }
    			public virtual string BannerUrl { get; set; }
    	
    	public BlogCategoryViewModel() : base() { }
    	public BlogCategoryViewModel(DataService.Models.Entities.BlogCategory entity) : base(entity) { }
    
    }
}