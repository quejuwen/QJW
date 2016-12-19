using System;

namespace DB.chinacfoclub
{
    public class T_Teacher 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public int? Topis { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Click { get; set; }
        public bool? Flag { get; set; }
        public string ClassName { get; set; }
    }
}
