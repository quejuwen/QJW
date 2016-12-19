using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopCouponUser
    /// </summary>
    public class KS_ShopCouponUser 
    {
        public int? ID { get; set; }
        public int? CouponId { get; set; }
        public string CouponNum { get; set; }
        public string UserName { get; set; }
        public string OrderID { get; set; }
        public DateTime? UseTime { get; set; }
        public Byte? UseFlag { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? MailTF { get; set; }
        public Decimal? AvailableMoney { get; set; }
        public string note { get; set; }
    }
}
