using System;

namespace DB.chinacfoclub
{
    public class tbl_Learn 
    {
        public int? ID { get; set; }
        public int? LessonId { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public bool? IsFocus { get; set; }
        public bool? IsMust { get; set; }
        public string MustDesc { get; set; }
        public bool? IsBuy { get; set; }
        public bool? IsFinish { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? LearnTime { get; set; }
        public Int16? StarAmount { get; set; }
        public string StarDesc { get; set; }
        public DateTime? StarDate { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? AddDate { get; set; }
        public Single? ExamScore { get; set; }
    }
}
