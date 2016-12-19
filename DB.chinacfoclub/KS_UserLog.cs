using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserLog
    /// </summary>
    public class KS_UserLog 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string Note { get; set; }
        public DateTime? AddDate { get; set; }
        public int? UserID { get; set; }
        public int? TransNum { get; set; }
        public int? CmtNum { get; set; }
        public string CopyFrom { get; set; }
        public string SinaWeiboID { get; set; }
        public int? InfoID { get; set; }
    }
}
