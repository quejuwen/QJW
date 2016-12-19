using System;

namespace DB.chinacfoclub
{
    public class tbl_LieKeBm 
    {
        public int? ID { get; set; }
        public int? LkId { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }
        public int? Amount { get; set; }
        public int? Price { get; set; }
        public string Payment { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
    }
}
