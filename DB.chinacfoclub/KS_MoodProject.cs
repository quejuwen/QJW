using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_MoodProject
    /// </summary>
    public class KS_MoodProject 
    {
        public int? ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContent { get; set; }
        public Byte? OnlyUser { get; set; }
        public int? UserOnce { get; set; }
        public string AllowGroupID { get; set; }
        public Byte? Status { get; set; }
        public int? TimeLimit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public Byte? typeflag { get; set; }
        public string templateid { get; set; }
        public Byte? ZCJTF { get; set; }
        public Byte? VerifyCodeTF { get; set; }
        public Byte? IsRewrite { get; set; }
        public Byte? IsVerify { get; set; }
        public int? MaxLen { get; set; }
    }
}
