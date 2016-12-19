using System;

namespace DB.chinacfoclub
{
    public class T_Course 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int? ClassID { get; set; }
        public int? TeacherID { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Descriptioon { get; set; }
        public string Contents { get; set; }
        public int? Topis { get; set; }
        public int? Click { get; set; }
        public int? ItemCount { get; set; }
        public bool? IsLast { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? Flag { get; set; }
        public bool? IsSubtitle { get; set; }
        public int? CourseTime { get; set; }
    }
}
