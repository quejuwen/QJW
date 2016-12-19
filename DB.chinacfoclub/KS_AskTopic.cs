using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskTopic
    /// </summary>
    public class KS_AskTopic 
    {
        public int? TopicID { get; set; }
        public int? classid { get; set; }
        public string UserName { get; set; }
        public string pclassname { get; set; }
        public string classname { get; set; }
        public string title { get; set; }
        public int? Expired { get; set; }
        public int? Closed { get; set; }
        public string PostTable { get; set; }
        public DateTime? DateAndTime { get; set; }
        public DateTime? LastPostTime { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public Byte? LockTopic { get; set; }
        public int? Reward { get; set; }
        public int? Hits { get; set; }
        public int? PostNum { get; set; }
        public int? CommentNum { get; set; }
        public Byte? TopicMode { get; set; }
        public Byte? AskedMode { get; set; }
        public int? Highlight { get; set; }
        public int? Broadcast { get; set; }
        public Byte? Anonymous { get; set; }
        public Byte? IsTop { get; set; }
        public int? supplement { get; set; }
        public Byte? Recommend { get; set; }
        public int? AskUserID { get; set; }
        public int? UserID { get; set; }
        public string BestUserName { get; set; }
        public int? BestUserId { get; set; }
    }
}
