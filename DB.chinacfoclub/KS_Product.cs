using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Product
    /// </summary>
    public class KS_Product 
    {
        public int? ID { get; set; }
        public string ProID { get; set; }
        public string Tid { get; set; }
        public string KeyWords { get; set; }
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        public string BigPhoto { get; set; }
        public string ProIntro { get; set; }
        public string ProModel { get; set; }
        public string ProSpecificat { get; set; }
        public string ProducerName { get; set; }
        public string TrademarkName { get; set; }
        public int? ServiceTerm { get; set; }
        public string Rank { get; set; }
        public string Unit { get; set; }
        public int? Hits { get; set; }
        public int? TotalNum { get; set; }
        public int? AlarmNum { get; set; }
        public Byte? IsDiscount { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? Price_Member { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string JSID { get; set; }
        public string TemplateID { get; set; }
        public string Fname { get; set; }
        public Byte? RefreshTF { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Rolls { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Verific { get; set; }
        public Byte? Comment { get; set; }
        public Byte? IsSpecial { get; set; }
        public Byte? IsTop { get; set; }
        public Byte? Slide { get; set; }
        public Byte? DelTF { get; set; }
        public int? BrandID { get; set; }
        public int? HitsByDay { get; set; }
        public int? HitsByWeek { get; set; }
        public int? HitsByMonth { get; set; }
        public DateTime? LastHitsTime { get; set; }
        public Byte? Strip { get; set; }
        public int? ClassID { get; set; }
        public Byte? ShowOnSpace { get; set; }
        public int? BigClassID { get; set; }
        public int? SmallClassID { get; set; }
        public string AttributeCart { get; set; }
        public string Inputer { get; set; }
        public string WapTemplateID { get; set; }
        public Byte? IsChangedBuy { get; set; }
        public Decimal? ChangeBuyNeedPrice { get; set; }
        public Decimal? ChangeBuyPresentPrice { get; set; }
        public Byte? IsLimitbuy { get; set; }
        public Decimal? LimitBuyPrice { get; set; }
        public int? LimitBuyTaskID { get; set; }
        public int? LimitBuyAmount { get; set; }
        public Single? Weight { get; set; }
        public string DownUrl { get; set; }
        public int? Membernum { get; set; }
        public int? Visitornum { get; set; }
        public string ArrGroupID { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeyWord { get; set; }
        public string SEODescript { get; set; }
    }
}
