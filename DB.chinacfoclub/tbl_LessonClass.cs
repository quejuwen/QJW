using System;

namespace DB.chinacfoclub
{
    public class tbl_LessonClass 
    {
        public int? ID { get; set; }
        public string ClassName { get; set; }
        public int? Flag { get; set; }
        public string ClassDesc { get; set; }
        public int? OrderFlag { get; set; }
        public string BigClassName { get; set; }
        public bool? IsDel { get; set; }
        public int? LessonCount { get; set; }
    }
}
