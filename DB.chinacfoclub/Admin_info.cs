using System;

namespace DB.chinacfoclub
{
    public class Admin_info 
    {
        public int? ID { get; set; }
        public int? Unid { get; set; }
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
        public int? flag { get; set; }
        public int? pic { get; set; }
        public string DefaultPic { get; set; }
        public string synopsis { get; set; }
        public string vouch { get; set; }
        public int? Audit { get; set; }
        public int? Popedom { get; set; }
    }
}
