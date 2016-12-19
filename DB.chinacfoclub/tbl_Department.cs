using System;

namespace DB.chinacfoclub
{
    public class tbl_Department 
    {
        public int? depID { get; set; }
        public string depName { get; set; }
        public int? depFatherID { get; set; }
        public int? depTopID { get; set; }
        public int? depLevel { get; set; }
        public int? depSortOrder { get; set; }
        public string depPhone { get; set; }
        public string depEmail { get; set; }
        public string depAddress { get; set; }
        public string depDesc { get; set; }
        public int? depManager { get; set; }
        public string depFax { get; set; }
        public Int16? RegionID { get; set; }
        public Int16? RegionCID { get; set; }
        public string depTitle { get; set; }
        public string depPost { get; set; }
        public string depContact { get; set; }
        public string depMobile { get; set; }
        public string depWeb { get; set; }
        public bool? isAudit { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? isDepart { get; set; }
        public bool? isProvince { get; set; }
        public int? CompanyAmount { get; set; }
        public string account_title { get; set; }
        public string account_bank { get; set; }
        public string account_code { get; set; }
        public Int16? depType { get; set; }
        public Int16? depMode { get; set; }
        public int? depModeMoney { get; set; }
        public int? SystemId { get; set; }
        public string DepQQ1 { get; set; }
        public string DepQQ2 { get; set; }
        public int? AcenterId { get; set; }
        public bool? IsDel { get; set; }
        public Int16? ShowOrder { get; set; }
        public bool? IsShow { get; set; }
    }
}
