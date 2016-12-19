using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Blog
    /// </summary>
    public class KS_Blog 
    {
        public int? BlogID { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string BlogName { get; set; }
        public string Domain { get; set; }
        public string Logo { get; set; }
        public int? ClassID { get; set; }
        public string Descript { get; set; }
        public string Announce { get; set; }
        public int? ContentLen { get; set; }
        public int? ListBlogNum { get; set; }
        public int? ListLogNum { get; set; }
        public int? ListReplayNum { get; set; }
        public int? ListGuestNum { get; set; }
        public int? TemplateID { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Recommend { get; set; }
        public int? Status { get; set; }
        public int? hits { get; set; }
        public string Banner { get; set; }
    }
}
