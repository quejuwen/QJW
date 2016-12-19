using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_OrderItem
    /// </summary>
    public class KS_OrderItem 
    {
        public int? ID { get; set; }
        public string OrderID { get; set; }
        public int? ProID { get; set; }
        public int? SaleType { get; set; }
        public Decimal? Price_Original { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? RealPrice { get; set; }
        public int? Amount { get; set; }
        public Decimal? TotalPrice { get; set; }
        public DateTime? BeginDate { get; set; }
        public int? ServiceTerm { get; set; }
        public string Remark { get; set; }
        public Decimal? PresentMoney { get; set; }
        public int? PresentPoint { get; set; }
        public int? PresentExp { get; set; }
        public string AttributeCart { get; set; }
        public Byte? IsChangedBuy { get; set; }
        public int? PackID { get; set; }
        public int? LimitBuyTaskID { get; set; }
        public Byte? IsLimitBuy { get; set; }
        public int? BundleSaleProID { get; set; }
        public string UserIP { get; set; }
        public int? IsMember { get; set; }
        public int? Score { get; set; }
        public int? AttrID { get; set; }
    }
}
