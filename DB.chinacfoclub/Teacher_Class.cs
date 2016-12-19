using System;

namespace DB.chinacfoclub
{
    public class Teacher_Class 
    {
        public Int16? Unid { get; set; }
        public string ClassName { get; set; }
        public Int16? Flag { get; set; }
        public Int16? OrderFlag { get; set; }
        public bool? isMust { get; set; }
        public bool? isMustM { get; set; }
        public string LessonObject { get; set; }
        public string ShortName { get; set; }
        public int? IsDel { get; set; }
    }
}
