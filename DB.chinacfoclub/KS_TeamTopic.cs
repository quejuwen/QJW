using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_TeamTopic
    /// </summary>
    public class KS_TeamTopic 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? TeamID { get; set; }
        public int? ParentID { get; set; }
        public string UserName { get; set; }
        public DateTime? AddDate { get; set; }
        public string UserIP { get; set; }
        public int? Status { get; set; }
        public int? isbest { get; set; }
        public int? istop { get; set; }
    }
}
