using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_InnerLink
    /// </summary>
    public class KS_InnerLink 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Opentype { get; set; }
        public DateTime? AddDate { get; set; }
        public int? OpenTF { get; set; }
        public int? CaseTF { get; set; }
        public int? Times { get; set; }
        public int? Start { get; set; }
    }
}
