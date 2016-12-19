using System;

namespace DB.chinacfoclub
{
    public class tbl_GradeLesson 
    {
        public int? ID { get; set; }
        public string GradeName { get; set; }
        public string GradeDesc { get; set; }
        public string LessonId { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? AddTime { get; set; }
        public string T_CourseId { get; set; }
    }
}
