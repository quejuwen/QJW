using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Order
    /// </summary>
    public class KS_Order 
    {
        public int? ID { get; set; }
        public string OrderID { get; set; }
        public string UserName { get; set; }
        public Decimal? MoneyTotal { get; set; }
        public Decimal? MoneyGoods { get; set; }
        public int? NeedInvoice { get; set; }
        public string InvoiceContent { get; set; }
        public int? Invoiced { get; set; }
        public string Remark { get; set; }
        public Decimal? MoneyReceipt { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? InputTime { get; set; }
        public string ContactMan { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public int? PaymentType { get; set; }
        public int? DeliverType { get; set; }
        public int? Status { get; set; }
        public int? DeliverStatus { get; set; }
        public int? EnableDownload { get; set; }
        public Decimal? PresentMoney { get; set; }
        public int? PresentPoint { get; set; }
        public int? PresentScore { get; set; }
        public Double? Discount_Payment { get; set; }
        public Decimal? Charge_Deliver { get; set; }
        public int? PayToUser { get; set; }
        public int? CouponUserID { get; set; }
        public Decimal? NoUseCouponMoney { get; set; }
        public Decimal? UseCouponMoney { get; set; }
        public DateTime? PayTime { get; set; }
        public string ToCity { get; set; }
        public Single? Weight { get; set; }
        public int? OrderType { get; set; }
        public Byte? ScoreTF { get; set; }
        public int? TotalScore { get; set; }
        public int? PayStatus { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public Decimal? UseScoreMoney { get; set; }
        public int? UseScore { get; set; }
        public string ServiceName { get; set; }
        public int? ServiceTimes { get; set; }
        public int? Validity { get; set; }
        public Byte? IsService { get; set; }
        public string alipaytradeno { get; set; }
        public string alipaytradestatus { get; set; }
        public int? PaymentPlatId { get; set; }
    }
}
