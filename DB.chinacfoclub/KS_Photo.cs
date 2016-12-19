using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Photo
    /// </summary>
    public class KS_Photo 
    {
        public int? ID { get; set; }
        public string Tid { get; set; }
        public string KeyWords { get; set; }
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        public string PicUrls { get; set; }
        public string PictureContent { get; set; }
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
        public Byte? Recommend { get; set; }
        public Byte? Rolls { get; set; }
        public int? Strip { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Verific { get; set; }
        public int? Comment { get; set; }
        public int? IsTop { get; set; }
        public int? Score { get; set; }
        public Byte? Slide { get; set; }
        public Byte? DelTF { get; set; }
        public int? InfoPurview { get; set; }
        public string ArrGroupID { get; set; }
        public int? ReadPoint { get; set; }
        public int? ChargeType { get; set; }
        public int? PitchTime { get; set; }
        public int? ReadTimes { get; set; }
        public int? DividePercent { get; set; }
        public string Inputer { get; set; }
        public string WapTemplateID { get; set; }
        public Byte? showstyle { get; set; }
        public int? PageNum { get; set; }
        public string MapMarker { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeyWord { get; set; }
        public string SEODescript { get; set; }
    }
}
