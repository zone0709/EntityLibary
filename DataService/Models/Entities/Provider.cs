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
    
    public partial class Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provider()
        {
            this.InventoryReceipts = new HashSet<InventoryReceipt>();
            this.ProviderProductItemMappings = new HashSet<ProviderProductItemMapping>();
            this.VATOrders = new HashSet<VATOrder>();
        }
    
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public Nullable<bool> IsAvailable { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public string License { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> Type { get; set; }
        public string VATCode { get; set; }
        public string AccountNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryReceipt> InventoryReceipts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderProductItemMapping> ProviderProductItemMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VATOrder> VATOrders { get; set; }
    }
}