using System;

namespace DB.chinacfoclub
{
    public class article_info 
    {
        public Decimal? Unid { get; set; }
        public string content { get; set; }
        public string title { get; set; }
        public int? Nclassid { get; set; }
        public int? classid { get; set; }
        public string Nkey { get; set; }
        public int? hits { get; set; }
        public DateTime? Intime { get; set; }
        public string writer { get; set; }
        public string writefrom { get; set; }
        public string author { get; set; }
        public bool? flag { get; set; }
        public bool? pic { get; set; }
        public string DefaultPic { get; set; }
        public string synopsis { get; set; }
        public string vouch { get; set; }
        public bool? Audit { get; set; }
        public bool? Popedom { get; set; }
        public int? depart { get; set; }
        public int? subdepart { get; set; }
        public int? lw_classid { get; set; }
        public int? departid { get; set; }
        public string DefaultApp { get; set; }
    }
}
