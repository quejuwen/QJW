using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_BlogInfo
    /// </summary>
    public class KS_BlogInfo 
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public int? TypeID { get; set; }
        public int? ClassID { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public string PassWord { get; set; }
        public int? Hits { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Face { get; set; }
        public string Weather { get; set; }
        public int? Status { get; set; }
        public int? best { get; set; }
        public int? IsTalk { get; set; }
        public int? TotalPut { get; set; }
        public string PhotoUrl { get; set; }
        public string SinaWeiboID { get; set; }
    }
}
