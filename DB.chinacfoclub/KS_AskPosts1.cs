using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskPosts1
    /// </summary>
    public class KS_AskPosts1 
    {
        public int? postsid { get; set; }
        public int? TopicID { get; set; }
        public int? classid { get; set; }
        public string UserName { get; set; }
        public string topic { get; set; }
        public string content { get; set; }
        public string addText { get; set; }
        public DateTime? PostTime { get; set; }
        public DateTime? DoneTime { get; set; }
        public int? length { get; set; }
        public int? star { get; set; }
        public Byte? satis { get; set; }
        public Byte? LockTopic { get; set; }
        public Byte? PostsMode { get; set; }
        public int? VoteNum { get; set; }
        public int? Plus { get; set; }
        public int? Minus { get; set; }
        public string PostIP { get; set; }
        public int? Report { get; set; }
        public int? UserId { get; set; }
        public int? IsZj { get; set; }
    }
}
