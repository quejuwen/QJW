using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GuestBook
    /// </summary>
    public class KS_GuestBook 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public int? UserID { get; set; }
        public string face { get; set; }
        public string Subject { get; set; }
        public string GuestIP { get; set; }
        public string AddTime { get; set; }
        public int? Verific { get; set; }
        public DateTime? LastReplayTime { get; set; }
        public string LastReplayUser { get; set; }
        public int? LastReplayUserID { get; set; }
        public int? TotalReplay { get; set; }
        public int? BoardID { get; set; }
        public int? hits { get; set; }
        public Byte? istop { get; set; }
        public Byte? isbest { get; set; }
        public Byte? purview { get; set; }
        public Byte? showip { get; set; }
        public Byte? showsign { get; set; }
        public int? showscore { get; set; }
        public Byte? isSlide { get; set; }
        public Byte? isPic { get; set; }
        public string PostTable { get; set; }
        public string AnnexExt { get; set; }
        public int? CategoryId { get; set; }
        public Byte? PostType { get; set; }
        public Byte? DelTf { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public Byte? isclose { get; set; }
    }
}
