using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopCoupon
    /// </summary>
    public class KS_ShopCoupon 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public Decimal? FaceValue { get; set; }
        public Decimal? MinAmount { get; set; }
        public int? CouponType { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Inputer { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? Status { get; set; }
        public Single? MaxDiscount { get; set; }
    }
}
