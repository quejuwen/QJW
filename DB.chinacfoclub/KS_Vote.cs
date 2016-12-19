using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Vote
    /// </summary>
    public class KS_Vote 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public Byte? TimeLimit { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public Byte? Nmtp { get; set; }
        public string GroupIds { get; set; }
        public int? Ipnum { get; set; }
        public int? IPnums { get; set; }
        public string TemplateID { get; set; }
        public DateTime? AddDate { get; set; }
        public string VoteType { get; set; }
        public string UserName { get; set; }
        public int? NewestTF { get; set; }
        public int? Status { get; set; }
        public int? TopicID { get; set; }
        public int? VoteNums { get; set; }
        public string VoteUserList { get; set; }
    }
}
