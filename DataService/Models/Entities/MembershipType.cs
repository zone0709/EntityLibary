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
    
    public partial class MembershipType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MembershipType()
        {
            this.Memberships = new HashSet<Membership>();
        }
    
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string AppendCode { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> TypeLevel { get; set; }
        public Nullable<int> TypePoint { get; set; }
        public int BrandId { get; set; }
        public Nullable<bool> IsMobile { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Brand Brand1 { get; set; }
        public virtual Brand Brand2 { get; set; }
        public virtual Brand Brand3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}