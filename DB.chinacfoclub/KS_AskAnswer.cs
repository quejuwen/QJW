using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskAnswer
    /// </summary>
    public class KS_AskAnswer 
    {
        public int? AnswerID { get; set; }
        public int? TopicID { get; set; }
        public int? ClassID { get; set; }
        public string pclassname { get; set; }
        public string classname { get; set; }
        public string UserName { get; set; }
        public string PostUsername { get; set; }
        public string title { get; set; }
        public DateTime? AnswerTime { get; set; }
        public string PostTable { get; set; }
        public int? AnswerNum { get; set; }
        public Byte? AnswerMode { get; set; }
        public Byte? TopicMode { get; set; }
        public int? UserId { get; set; }
    }
}
