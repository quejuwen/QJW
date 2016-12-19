using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ItemSign
    /// </summary>
    public class KS_ItemSign 
    {
        public int? ID { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public string UserName { get; set; }
        public DateTime? AddDate { get; set; }
        public string Content { get; set; }
    }
}
