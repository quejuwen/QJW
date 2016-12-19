using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_BlogMessage
    /// </summary>
    public class KS_BlogMessage 
    {
        public int? ID { get; set; }
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
        public int? Status { get; set; }
    }
}
