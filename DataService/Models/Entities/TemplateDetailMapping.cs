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
    
    public partial class TemplateDetailMapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TemplateDetailMapping()
        {
            this.PaySlips = new HashSet<PaySlip>();
        }
    
        public int Id { get; set; }
        public int PaySlipTemplateId { get; set; }
        public Nullable<int> PayrollDetailId { get; set; }
        public bool Active { get; set; }
    
        public virtual PayrollDetail PayrollDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaySlip> PaySlips { get; set; }
        public virtual PaySlipTemplate PaySlipTemplate { get; set; }
    }
}