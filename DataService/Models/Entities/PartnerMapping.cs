//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerMapping
    {
        public int BrandId { get; set; }
        public int PartnerId { get; set; }
        public string Config { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> Active { get; set; }
        public int Id { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Brand Brand1 { get; set; }
        public virtual Brand Brand2 { get; set; }
        public virtual Brand Brand3 { get; set; }
        public virtual Brand Brand4 { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual Partner Partner1 { get; set; }
        public virtual Partner Partner2 { get; set; }
        public virtual Partner Partner3 { get; set; }
    }
}
