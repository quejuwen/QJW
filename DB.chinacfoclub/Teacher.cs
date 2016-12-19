using System;

namespace DB.chinacfoclub
{
    public class Teacher 
    {
        public int? T_id { get; set; }
        public string T_name { get; set; }
        public string T_sex { get; set; }
        public string T_idcode { get; set; }
        public string T_zhiwu { get; set; }
        public string T_cell { get; set; }
        public string T_tel { get; set; }
        public string T_email { get; set; }
        public string T_resume { get; set; }
        public string T_pic { get; set; }
        public string T_company { get; set; }
        public string T_class { get; set; }
        public string T_password { get; set; }
        public string T_QQ { get; set; }
        public string T_fax { get; set; }
        public string T_addr { get; set; }
        public bool? T_type { get; set; }
        public string T_detail { get; set; }
        public int? depart { get; set; }
        public int? subdepart { get; set; }
        public int? hits { get; set; }
        public string smallpic { get; set; }
        public string zhushu { get; set; }
        public string rongyu { get; set; }
        public string fuwuqiye { get; set; }
        public int? payment { get; set; }
        public bool? flag { get; set; }
        public Int16? ClassID { get; set; }
        public Int16? NClassID { get; set; }
        public string DepartMent { get; set; }
        public int? T_price { get; set; }
        public int? unid { get; set; }
        public bool? isTeacher { get; set; }
        public int? departid { get; set; }
        public bool? isWeiyuan { get; set; }
        public int? W_departid { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public Int16? orderflag { get; set; }
        public bool? IsStar { get; set; }
        public bool? IsAudit { get; set; }
        public int? AcenterId { get; set; }
        public string Province { get; set; }
        public bool? IsAuditWeiyuan { get; set; }
        public bool? FlagWeiyuan { get; set; }
        public bool? IsSmallPic { get; set; }
    }
}
