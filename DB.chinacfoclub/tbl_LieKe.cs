using System;

namespace DB.chinacfoclub
{
    public class tbl_LieKe 
    {
        public int? Id { get; set; }
        public int? ClassId { get; set; }
        public string Title { get; set; }
        public string Teacher { get; set; }
        public string Price { get; set; }
        public string Field { get; set; }
        public string Promo { get; set; }
        public string Place { get; set; }
        public string Side { get; set; }
        public string ClassDate { get; set; }
        public string Service { get; set; }
        public string Phone { get; set; }
        public string ClassDetail { get; set; }
        public string TeacherResume { get; set; }
        public string ClassGoal { get; set; }
        public string ClassPerson { get; set; }
        public string ClassPic { get; set; }
        public string ClassDoc { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsAudit { get; set; }
        public int? uid { get; set; }
        public string LoginUser { get; set; }
    }
}
