using System;

namespace DB.chinacfoclub
{
    public class tbl_AskTopic 
    {
        public int? ID { get; set; }
        public string Content { get; set; }
        public int? Hits { get; set; }
        public int? FocusCount { get; set; }
        public int? PostCount { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
        public int? Topis { get; set; }
        public bool? IsGood { get; set; }
        public int? LessonId { get; set; }
    }
}
