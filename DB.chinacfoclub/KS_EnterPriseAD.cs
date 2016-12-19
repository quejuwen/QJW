using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_EnterPriseAD
    /// </summary>
    public class KS_EnterPriseAD 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string PhotoUrl { get; set; }
        public int? ADType { get; set; }
        public int? BigClassID { get; set; }
        public int? SmallClassID { get; set; }
        public string AdWZ { get; set; }
        public string UserName { get; set; }
        public DateTime? BeginDate { get; set; }
        public int? datatimed { get; set; }
        public int? Status { get; set; }
        public DateTime? ShowTime { get; set; }
    }
}
