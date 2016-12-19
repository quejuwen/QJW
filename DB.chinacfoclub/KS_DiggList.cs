using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_DiggList
    /// </summary>
    public class KS_DiggList 
    {
        public int? DiggID { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public DateTime? LastDiggTime { get; set; }
        public string LastDiggUser { get; set; }
        public int? DiggNum { get; set; }
        public int? CDiggNum { get; set; }
    }
}
