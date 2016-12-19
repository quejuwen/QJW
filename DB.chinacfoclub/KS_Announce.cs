using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Announce
    /// </summary>
    public class KS_Announce 
    {
        public int? ID { get; set; }
        public int? ChannelID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime? AddDate { get; set; }
        public int? NewestTF { get; set; }
    }
}
