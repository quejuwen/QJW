using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Form_fk
    /// </summary>
    public class KS_Form_fk 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public DateTime? AddDate { get; set; }
        public string Note { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public Byte? Status { get; set; }
        public string KS_lx { get; set; }
        public string KS_nr { get; set; }
        public string KS_nc { get; set; }
        public string KS_lxfs { get; set; }
    }
}
