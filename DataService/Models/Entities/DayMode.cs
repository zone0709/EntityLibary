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
    
    public partial class DayMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DayMode()
        {
            this.TimeModeRules = new HashSet<TimeModeRule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> DayFilter { get; set; }
        public Nullable<int> IsSpecialDay { get; set; }
        public Nullable<int> Priority { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeModeRule> TimeModeRules { get; set; }
    }
}
