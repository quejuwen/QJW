using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Form
    /// </summary>
    public class KS_Form 
    {
        public int? ID { get; set; }
        public string FormName { get; set; }
        public string TableName { get; set; }
        public string UploadDir { get; set; }
        public Byte? TimeLimit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public Byte? OnlyUser { get; set; }
        public string AllowGroupID { get; set; }
        public Byte? UserOnce { get; set; }
        public string Descript { get; set; }
        public Byte? ShowNum { get; set; }
        public Byte? status { get; set; }
        public string Template { get; set; }
        public Byte? PostByStep { get; set; }
        public int? StepNum { get; set; }
        public int? ToUserEmail { get; set; }
        public Byte? AnonymousUpload { get; set; }
    }
}
