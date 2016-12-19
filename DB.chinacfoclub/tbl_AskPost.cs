using System;

namespace DB.chinacfoclub
{
    public class tbl_AskPost 
    {
        public int? ID { get; set; }
        public int? Tid { get; set; }
        public string Content { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public DateTime? AddDate { get; set; }
        public int? DiggCount { get; set; }
        public bool? IsDel { get; set; }
    }
}
