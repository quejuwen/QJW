using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Message
    /// </summary>
    public class KS_Message 
    {
        public int? ID { get; set; }
        public string Sender { get; set; }
        public string Incept { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? Flag { get; set; }
        public DateTime? Sendtime { get; set; }
        public int? DelR { get; set; }
        public int? DelS { get; set; }
        public int? IsSend { get; set; }
    }
}
