using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Article
    /// </summary>
    public class KS_Article 
    {
        public int? ID { get; set; }
        public string Tid { get; set; }
        public string KeyWords { get; set; }
        public string TitleType { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Intro { get; set; }
        public Byte? ShowComment { get; set; }
        public string TitleFontColor { get; set; }
        public string TitleFontType { get; set; }
        public string ArticleContent { get; set; }
        public string Author { get; set; }
        public string Origin { get; set; }
        public string Rank { get; set; }
        public int? Hits { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string JSID { get; set; }
        public string TemplateID { get; set; }
        public string Fname { get; set; }
        public Byte? RefreshTF { get; set; }
        public Byte? PicNews { get; set; }
        public Byte? Changes { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Rolls { get; set; }
        public Byte? Strip { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Verific { get; set; }
        public Byte? Slide { get; set; }
        public Byte? IsVideo { get; set; }
        public Byte? Comment { get; set; }
        public Byte? IsTop { get; set; }
        public Byte? DelTF { get; set; }
        public Byte? InfoPurview { get; set; }
        public string ArrGroupID { get; set; }
        public int? ReadPoint { get; set; }
        public Byte? ChargeType { get; set; }
        public int? PitchTime { get; set; }
        public int? ReadTimes { get; set; }
        public int? DividePercent { get; set; }
        public int? HitsByDay { get; set; }
        public int? HitsByWeek { get; set; }
        public int? HitsByMonth { get; set; }
        public DateTime? LastHitsTime { get; set; }
        public string PhotoUrl { get; set; }
        public string Inputer { get; set; }
        public string PageTitle { get; set; }
        public string WapTemplateID { get; set; }
        public Byte? IsSign { get; set; }
        public string signuser { get; set; }
        public Byte? SignDateLimit { get; set; }
        public DateTime? SignDateEnd { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string MapMarker { get; set; }
        public int? PostId { get; set; }
        public string PostTable { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeyWord { get; set; }
        public string SEODescript { get; set; }
    }
}
