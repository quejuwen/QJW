using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Feedback
    /// </summary>
    public class KS_Feedback 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Object { get; set; }
        public string Content { get; set; }
        public string HopeSolution { get; set; }
        public DateTime? AddDate { get; set; }
        public string Accepted { get; set; }
        public string AcceptResult { get; set; }
        public DateTime? AcceptTime { get; set; }
    }
}
