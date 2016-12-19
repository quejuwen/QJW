using System;

namespace DB.chinacfoclub
{
    public class T_CourseItems 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int? CourseID { get; set; }
        public string CourseUrl { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public int? PlayTime { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? Flag { get; set; }
        public int? topis { get; set; }
        public int? Price { get; set; }
    }
}
