using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ItemInfo
    /// </summary>
    public class KS_ItemInfo 
    {
        public int? ID { get; set; }
        public int? InfoID { get; set; }
        public int? ChannelID { get; set; }
        public string Title { get; set; }
        public string Tid { get; set; }
        public string Intro { get; set; }
        public string KeyWords { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Inputer { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Rolls { get; set; }
        public Byte? Strip { get; set; }
        public Byte? Popular { get; set; }
        public Byte? Slide { get; set; }
        public Byte? IsTop { get; set; }
        public Byte? Comment { get; set; }
        public int? Hits { get; set; }
        public int? HitsByDay { get; set; }
        public int? HitsByWeek { get; set; }
        public int? HitsByMonth { get; set; }
        public DateTime? LastHitsTime { get; set; }
        public Byte? Verific { get; set; }
        public Byte? DelTF { get; set; }
        public string Fname { get; set; }
    }
}
