using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GuestBoard
    /// </summary>
    public class KS_GuestBoard 
    {
        public int? ID { get; set; }
        public string BoardName { get; set; }
        public string Note { get; set; }
        public int? ParentID { get; set; }
        public string Master { get; set; }
        public DateTime? AddDate { get; set; }
        public int? OrderID { get; set; }
        public int? TodayNum { get; set; }
        public int? TopicNum { get; set; }
        public int? PostNum { get; set; }
        public string LastPost { get; set; }
        public string BoardRules { get; set; }
        public string Settings { get; set; }
        public Byte? Locked { get; set; }
    }
}
