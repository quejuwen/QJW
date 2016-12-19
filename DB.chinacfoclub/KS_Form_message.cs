using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Form_message
    /// </summary>
    public class KS_Form_message 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public DateTime? AddDate { get; set; }
        public string Note { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public Byte? Status { get; set; }
        public string KS_type { get; set; }
        public string KS_text { get; set; }
        public string KS_mobile { get; set; }
        public string KS_QQ { get; set; }
        public string KS_Email { get; set; }
        public string KS_ww { get; set; }
    }
}
