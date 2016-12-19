using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogPoint
    /// </summary>
    public class KS_LogPoint 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public DateTime? AddDate { get; set; }
        public string IP { get; set; }
        public int? InOrOutFlag { get; set; }
        public Single? Point { get; set; }
        public Single? CurrPoint { get; set; }
        public int? Times { get; set; }
        public string User { get; set; }
        public string Descript { get; set; }
        public Byte? ContributeFlag { get; set; }
    }
}
