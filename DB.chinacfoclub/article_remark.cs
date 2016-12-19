using System;

namespace DB.chinacfoclub
{
    public class article_remark 
    {
        public int? unid { get; set; }
        public int? articleID { get; set; }
        public string username { get; set; }
        public string content { get; set; }
        public int? faceid { get; set; }
        public DateTime? Intime { get; set; }
        public string ip { get; set; }
    }
}
