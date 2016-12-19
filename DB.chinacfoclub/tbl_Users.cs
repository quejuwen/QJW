using System;

namespace DB.chinacfoclub
{
    public class tbl_Users 
    {
        public int? ID { get; set; }
        public int? DepId { get; set; }
        public int? DepartId { get; set; }
        public string LoginUser { get; set; }
        public string LoginPass { get; set; }
        public string PassWord { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string UserMobile { get; set; }
        public string UserEmail { get; set; }
        public bool? IsVerifyMobile { get; set; }
        public bool? IsCpmqa { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
        public int? CompanyId { get; set; }
        public int? LiveCount { get; set; }
        public DateTime? LiveDate { get; set; }
        public int? CpmqaUid { get; set; }
        public int? CpmUid { get; set; }
        public int? CpmAdminId { get; set; }
        public int? CpmTeacherId { get; set; }
        public int? CpmStuserId { get; set; }
        public int? CpmqaAdminId { get; set; }
    }
}
