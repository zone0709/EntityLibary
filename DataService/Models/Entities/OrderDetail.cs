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
    
    public partial class OrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetail()
        {
            this.OrderDetail1 = new HashSet<OrderDetail>();
            this.OrderDetailPromotionMappings = new HashSet<OrderDetailPromotionMapping>();
        }
    
        public int OrderDetailID { get; set; }
        public int RentID { get; set; }
        public int ProductID { get; set; }
        public double TotalAmount { get; set; }
        public int Quantity { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public double FinalAmount { get; set; }
        public bool IsAddition { get; set; }
        public string DetailDescription { get; set; }
        public double Discount { get; set; }
        public Nullable<double> TaxPercent { get; set; }
        public Nullable<double> TaxValue { get; set; }
        public double UnitPrice { get; set; }
        public Nullable<int> ProductType { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> ProductOrderType { get; set; }
        public int ItemQuantity { get; set; }
        public Nullable<int> TmpDetailId { get; set; }
        public Nullable<int> OrderDetailPromotionMappingId { get; set; }
        public Nullable<int> OrderPromotionMappingId { get; set; }
        public string OrderDetailAtt1 { get; set; }
        public string OrderDetailAtt2 { get; set; }
    
        public virtual Order Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail1 { get; set; }
        public virtual OrderDetail OrderDetail2 { get; set; }
        public virtual OrderDetailPromotionMapping OrderDetailPromotionMapping { get; set; }
        public virtual OrderPromotionMapping OrderPromotionMapping { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetailPromotionMapping> OrderDetailPromotionMappings { get; set; }
    }
}