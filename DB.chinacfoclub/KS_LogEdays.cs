using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogEdays
    /// </summary>
    public class KS_LogEdays 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public int? Edays { get; set; }
        public int? InOrOutFlag { get; set; }
        public DateTime? AddDate { get; set; }
        public string IP { get; set; }
        public string user { get; set; }
        public string Descript { get; set; }
    }
}
