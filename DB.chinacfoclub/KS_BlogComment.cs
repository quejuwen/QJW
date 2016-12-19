using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_BlogComment
    /// </summary>
    public class KS_BlogComment 
    {
        public int? ID { get; set; }
        public int? LogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public string AnounName { get; set; }
        public string HomePage { get; set; }
        public string UserIP { get; set; }
        public DateTime? AddDate { get; set; }
        public string Replay { get; set; }
        public DateTime? ReplayDate { get; set; }
        public Byte? ReadTF { get; set; }
    }
}
