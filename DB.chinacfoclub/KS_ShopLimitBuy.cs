using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopLimitBuy
    /// </summary>
    public class KS_ShopLimitBuy 
    {
        public int? ID { get; set; }
        public string TaskName { get; set; }
        public Byte? TaskType { get; set; }
        public DateTime? LimitBuyBeginTime { get; set; }
        public DateTime? LimitBuyEndTime { get; set; }
        public int? LimitBuyPayTime { get; set; }
        public string Intro { get; set; }
        public Byte? Status { get; set; }
        public DateTime? AddDate { get; set; }
        public string TemplateID { get; set; }
    }
}
