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
    
    public partial class OrderViewModel : DataService.ViewModels.BaseEntityViewModel<DataService.Models.Entities.Order>
    {
    	
    			public virtual int RentID { get; set; }
    			public virtual string InvoiceID { get; set; }
    			public virtual Nullable<System.DateTime> CheckInDate { get; set; }
    			public virtual Nullable<System.DateTime> CheckOutDate { get; set; }
    			public virtual Nullable<System.DateTime> ApproveDate { get; set; }
    			public virtual double TotalAmount { get; set; }
    			public virtual double Discount { get; set; }
    			public virtual double DiscountOrderDetail { get; set; }
    			public virtual double FinalAmount { get; set; }
    			public virtual int OrderStatus { get; set; }
    			public virtual Nullable<int> RentStatus { get; set; }
    			public virtual int OrderType { get; set; }
    			public virtual int RentType { get; set; }
    			public virtual string Notes { get; set; }
    			public virtual string FeeDescription { get; set; }
    			public virtual string CheckInPerson { get; set; }
    			public virtual string CheckOutPerson { get; set; }
    			public virtual string ApprovePerson { get; set; }
    			public virtual Nullable<int> PriceGroupID { get; set; }
    			public virtual Nullable<System.DateTime> BookingDate { get; set; }
    			public virtual Nullable<System.DateTime> ArrivalDate { get; set; }
    			public virtual Nullable<System.DateTime> DepartureDate { get; set; }
    			public virtual Nullable<int> CustomerID { get; set; }
    			public virtual Nullable<int> CustomerTypeId { get; set; }
    			public virtual Nullable<int> SubRentGroupID { get; set; }
    			public virtual Nullable<int> RoomId { get; set; }
    			public virtual bool IsFixedPrice { get; set; }
    			public virtual Nullable<System.DateTime> LastRecordDate { get; set; }
    			public virtual string ServedPerson { get; set; }
    			public virtual Nullable<int> StoreID { get; set; }
    			public virtual Nullable<int> SourceID { get; set; }
    			public virtual int SourceType { get; set; }
    			public virtual string DeliveryAddress { get; set; }
    			public virtual Nullable<int> DeliveryStatus { get; set; }
    			public virtual Nullable<int> OrderDetailsTotalQuantity { get; set; }
    			public virtual Nullable<int> CheckinHour { get; set; }
    			public virtual Nullable<int> TotalInvoicePrint { get; set; }
    			public virtual Nullable<double> VAT { get; set; }
    			public virtual Nullable<double> VATAmount { get; set; }
    			public virtual Nullable<int> NumberOfGuest { get; set; }
    			public virtual string Att1 { get; set; }
    			public virtual string Att2 { get; set; }
    			public virtual string Att3 { get; set; }
    			public virtual string Att4 { get; set; }
    			public virtual string Att5 { get; set; }
    			public virtual int GroupPaymentStatus { get; set; }
    			public virtual string DeliveryReceiver { get; set; }
    			public virtual string DeliveryPhone { get; set; }
    			public virtual Nullable<System.DateTime> LastModifiedPayment { get; set; }
    			public virtual Nullable<System.DateTime> LastModifiedOrderDetail { get; set; }
    			public virtual Nullable<int> PaymentStatus { get; set; }
    			public virtual Nullable<int> DeliveryType { get; set; }
    			public virtual Nullable<int> DeliveryPayment { get; set; }
    			public virtual Nullable<int> InvoiceStatus { get; set; }
    			public virtual Nullable<int> WardCode { get; set; }
    			public virtual Nullable<int> DistrictCode { get; set; }
    			public virtual Nullable<int> ProvinceCode { get; set; }
    			public virtual Nullable<int> PromotionPartnerId { get; set; }
    			public virtual Nullable<double> MemberPoint { get; set; }
    			public virtual string Receiver { get; set; }
    			public virtual Nullable<bool> IsExported { get; set; }
    	
    	public OrderViewModel() : base() { }
    	public OrderViewModel(DataService.Models.Entities.Order entity) : base(entity) { }
    
    }
}