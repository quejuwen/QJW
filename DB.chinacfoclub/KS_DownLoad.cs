using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_DownLoad
    /// </summary>
    public class KS_DownLoad 
    {
        public int? ID { get; set; }
        public string Tid { get; set; }
        public string KeyWords { get; set; }
        public string Title { get; set; }
        public string DownVersion { get; set; }
        public string DownLB { get; set; }
        public string DownYY { get; set; }
        public string DownSQ { get; set; }
        public string DownPT { get; set; }
        public string DownSize { get; set; }
        public string YSDZ { get; set; }
        public string ZCDZ { get; set; }
        public string JYMM { get; set; }
        public string PhotoUrl { get; set; }
        public string BigPhoto { get; set; }
        public string DownUrls { get; set; }
        public string DownContent { get; set; }
        public string Author { get; set; }
        public string Origin { get; set; }
        public string Rank { get; set; }
        public DateTime? LastHitsTime { get; set; }
        public int? Hits { get; set; }
        public int? HitsByDay { get; set; }
        public int? HitsByWeek { get; set; }
        public int? HitsByMonth { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string JSID { get; set; }
        public string TemplateID { get; set; }
        public string Fname { get; set; }
        public Byte? RefreshTF { get; set; }
        public Byte? Rolls { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Slide { get; set; }
        public Byte? Verific { get; set; }
        public int? Comment { get; set; }
        public int? IsTop { get; set; }
        public Byte? DelTF { get; set; }
        public Byte? InfoPurview { get; set; }
        public string ArrGroupID { get; set; }
        public int? ReadPoint { get; set; }
        public Byte? ChargeType { get; set; }
        public int? PitchTime { get; set; }
        public int? ReadTimes { get; set; }
        public int? DividePercent { get; set; }
        public Byte? strip { get; set; }
        public string Inputer { get; set; }
        public string WapTemplateID { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeyWord { get; set; }
        public string SEODescript { get; set; }
    }
}
