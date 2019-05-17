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
    
    public partial class SalaryRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalaryRule()
        {
            this.TemplateRuleMappings = new HashSet<TemplateRuleMapping>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TimeModeRuleId { get; set; }
        public double MinTimeDuration { get; set; }
        public double MaxTimeDuration { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<double> Rate { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
    
        public virtual TimeModeRule TimeModeRule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateRuleMapping> TemplateRuleMappings { get; set; }
    }
}
