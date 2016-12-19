using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Favorite
    /// </summary>
    public class KS_Favorite 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
