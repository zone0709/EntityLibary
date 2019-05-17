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
    
    public partial class PaySlip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaySlip()
        {
            this.PayslipAttributeMappings = new HashSet<PayslipAttributeMapping>();
            this.PaySlipItems = new HashSet<PaySlipItem>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PayrollPeriodId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> TemplateDetailMappingId { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<double> FinalPaid { get; set; }
        public bool Active { get; set; }
    
        public virtual PayrollPeriod PayrollPeriod { get; set; }
        public virtual TemplateDetailMapping TemplateDetailMapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayslipAttributeMapping> PayslipAttributeMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaySlipItem> PaySlipItems { get; set; }
    }
}
