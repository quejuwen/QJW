using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogScore
    /// </summary>
    public class KS_LogScore 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public DateTime? AddDate { get; set; }
        public string IP { get; set; }
        public Byte? InOrOutFlag { get; set; }
        public int? Score { get; set; }
        public int? CurrScore { get; set; }
        public string User { get; set; }
        public string Descript { get; set; }
        public int? channelid { get; set; }
        public int? infoid { get; set; }
        public int? Times { get; set; }
        public int? AvailableScore { get; set; }
    }
}
