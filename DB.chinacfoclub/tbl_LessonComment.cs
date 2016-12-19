using System;

namespace DB.chinacfoclub
{
    public class tbl_LessonComment 
    {
        public int? ID { get; set; }
        public int? LessonId { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public Int16? Score { get; set; }
        public string Comment { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
    }
}
