using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Form_bm
    /// </summary>
    public class KS_Form_bm 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public DateTime? AddDate { get; set; }
        public string Note { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public Byte? Status { get; set; }
        public string KS_xm { get; set; }
        public string KS_Tel { get; set; }
    }
}
