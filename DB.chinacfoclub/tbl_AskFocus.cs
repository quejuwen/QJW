using System;

namespace DB.chinacfoclub
{
    public class tbl_AskFocus 
    {
        public int? ID { get; set; }
        public int? Tid { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
