using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Digg
    /// </summary>
    public class KS_Digg 
    {
        public int? ID { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public int? DiggID { get; set; }
        public DateTime? DiggTime { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public Byte? DiggType { get; set; }
    }
}
