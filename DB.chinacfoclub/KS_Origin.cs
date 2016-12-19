using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Origin
    /// </summary>
    public class KS_Origin 
    {
        public string ID { get; set; }
        public string OriginName { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Contact { get; set; }
        public string Telphone { get; set; }
        public string UnitName { get; set; }
        public string UnitAddress { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }
        public string HomePage { get; set; }
        public string Note { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? OriginType { get; set; }
        public int? ChannelID { get; set; }
    }
}
