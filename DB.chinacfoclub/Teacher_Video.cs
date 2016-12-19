using System;

namespace DB.chinacfoclub
{
    public class Teacher_Video 
    {
        public int? ID { get; set; }
        public int? T_id { get; set; }
        public string VideoUrl { get; set; }
        public string VideoTitle { get; set; }
        public string VideoHtml { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
    }
}
