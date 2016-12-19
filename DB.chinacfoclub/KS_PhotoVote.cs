using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PhotoVote
    /// </summary>
    public class KS_PhotoVote 
    {
        public int? ID { get; set; }
        public int? ChannelID { get; set; }
        public string ClassID { get; set; }
        public string InfoID { get; set; }
        public DateTime? VoteTime { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public string VoteOptions { get; set; }
    }
}
