using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GuestReply
    /// </summary>
    public class KS_GuestReply 
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public int? ParentID { get; set; }
        public int? TopicID { get; set; }
        public string TxtHead { get; set; }
        public string Content { get; set; }
        public DateTime? ReplayTime { get; set; }
        public Byte? Verific { get; set; }
        public Byte? showip { get; set; }
        public Byte? showsign { get; set; }
        public int? Opposition { get; set; }
        public int? Support { get; set; }
        public int? deltf { get; set; }
    }
}
