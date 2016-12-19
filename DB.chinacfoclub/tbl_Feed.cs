using System;

namespace DB.chinacfoclub
{
    public class tbl_Feed 
    {
        public int? ID { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? AddDate { get; set; }
        public string Content { get; set; }
        public string DoAction { get; set; }
        public string FromTitle { get; set; }
        public string FromUrl { get; set; }
        public string FromDesc { get; set; }
    }
}
