using System;

namespace DB.chinacfoclub
{
    public class course 
    {
        public int? C_id { get; set; }
        public string C_title { get; set; }
        public int? C_time { get; set; }
        public string C_detail { get; set; }
        public string C_append { get; set; }
        public string C_class { get; set; }
        public int? T_id { get; set; }
        public bool? flag { get; set; }
        public int? C_ClassID { get; set; }
        public bool? audit { get; set; }
        public bool? auditM { get; set; }
        public bool? isMust { get; set; }
        public int? C_Price { get; set; }
        public int? C_PriceDep { get; set; }
    }
}
