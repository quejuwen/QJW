using System;

namespace DB.chinacfoclub
{
    public class Lessons 
    {
        public int? LessonId { get; set; }
        public int? C_id { get; set; }
        public DateTime? LessonDate { get; set; }
        public string LessonAddr { get; set; }
        public Decimal? LessonPrice { get; set; }
        public Single? LessonDay { get; set; }
        public Int16? depart { get; set; }
        public Int16? subdepart { get; set; }
        public bool? flag { get; set; }
        public bool? isAgree { get; set; }
        public DateTime? AgreeTime { get; set; }
        public bool? weixing { get; set; }
        public int? departid { get; set; }
        public string LessonClass { get; set; }
        public DateTime? LessonDate1 { get; set; }
        public DateTime? LessonDate2 { get; set; }
        public string CoverPic { get; set; }
        public int? T_CourseID { get; set; }
        public int? ClassID { get; set; }
        public int? ClassCID { get; set; }
        public Int16? RemarkTotal { get; set; }
        public Int16? RemarkGood { get; set; }
        public Int16? RemarkMiddle { get; set; }
        public Int16? RemarkBad { get; set; }
        public DateTime? LessonDateEnd { get; set; }
        public DateTime? LessonDateEnd1 { get; set; }
        public Single? CommentScore { get; set; }
        public int? CommentCount { get; set; }
        public int? PracticeId { get; set; }
        public int? ExamId { get; set; }
        public bool? IsLocalFlv { get; set; }
    }
}
