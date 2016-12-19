using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogConsum
    /// </summary>
    public class KS_LogConsum 
    {
        public int? LogId { get; set; }
        public int? BasicType { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public DateTime? AddDate { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public int? Times { get; set; }
    }
}
