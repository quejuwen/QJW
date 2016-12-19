using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GroupBuy
    /// </summary>
    public class KS_GroupBuy 
    {
        public int? ID { get; set; }
        public string Subject { get; set; }
        public string PhotoUrl { get; set; }
        public string BigPhoto { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? AddDate { get; set; }
        public int? ClassID { get; set; }
        public string Intro { get; set; }
        public string Highlights { get; set; }
        public string Protection { get; set; }
        public string Notes { get; set; }
        public Byte? Locked { get; set; }
        public Byte? EndTF { get; set; }
        public Byte? AllowBMFlag { get; set; }
        public string AllowArrGroupID { get; set; }
        public int? minnum { get; set; }
        public DateTime? minnumtime { get; set; }
        public Byte? IsSuccess { get; set; }
        public Decimal? Price_Original { get; set; }
        public Decimal? Price { get; set; }
        public Single? Discount { get; set; }
        public Single? Weight { get; set; }
        public int? LimitBuyNum { get; set; }
        public Byte? Recommend { get; set; }
        public int? ProvinceID { get; set; }
        public int? CityID { get; set; }
        public int? HasBuyNum { get; set; }
        public int? MustPayOnline { get; set; }
        public int? CleanCart { get; set; }
        public int? ShowDelivery { get; set; }
        public Byte? Comment { get; set; }
    }
}
