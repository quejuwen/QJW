using System;

namespace DB.chinacfoclub
{
    public class tbl_Online 
    {
        public int? ID { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public DateTime? LoginDate { get; set; }
        public string LoginIp { get; set; }
    }
}
