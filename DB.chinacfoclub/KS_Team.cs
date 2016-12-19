using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Team
    /// </summary>
    public class KS_Team 
    {
        public int? ID { get; set; }
        public string TeamName { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public int? ClassID { get; set; }
        public Byte? JoinTF { get; set; }
        public int? Point { get; set; }
        public string Announce { get; set; }
        public DateTime? AddDate { get; set; }
        public string Note { get; set; }
        public Byte? Verific { get; set; }
        public int? TemplateID { get; set; }
        public Byte? recommend { get; set; }
    }
}
