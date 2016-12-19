using System;

namespace DB.chinacfoclub
{
    public class Cpm_ArticleInfo 
    {
        public int? ID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int? ClassId { get; set; }
        public int? NClassId { get; set; }
        public int? Hits { get; set; }
        public string DefaultPic { get; set; }
        public string DefaultApp { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? InTime { get; set; }
        public bool? IsShow { get; set; }
        public int? OrderFlag { get; set; }
        public string JumpUrl { get; set; }
    }
}
