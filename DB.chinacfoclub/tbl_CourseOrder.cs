using System;

namespace DB.chinacfoclub
{
    public class tbl_CourseOrder 
    {
        public int? ID { get; set; }
        public int? C_Id { get; set; }
        public int? DepartId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderDay { get; set; }
        public int? OrderPrice { get; set; }
        public string OrderDemo { get; set; }
        public bool? IsTeacherAgree { get; set; }
        public DateTime? AgreeTime { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
