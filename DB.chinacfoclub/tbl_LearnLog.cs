using System;

namespace DB.chinacfoclub
{
    public class tbl_LearnLog 
    {
        public int? ID { get; set; }
        public int? LessonId { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public int? ItemId { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public int? LearnTime { get; set; }
        public string LoginIp { get; set; }
        public bool? IsDel { get; set; }
    }
}
