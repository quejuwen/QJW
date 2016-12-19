using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_SiteCount
    /// </summary>
    public class KS_SiteCount 
    {
        public int? id { get; set; }
        public int? UniqueIP { get; set; }
        public int? Pageview { get; set; }
        public DateTime? CountDate { get; set; }
        public int? google { get; set; }
        public int? baidu { get; set; }
        public int? yahoo { get; set; }
        public int? C3721 { get; set; }
        public int? zhongsou { get; set; }
        public int? sogou { get; set; }
        public int? other { get; set; }
        public int? DirectInput { get; set; }
        public int? AlexaToolbar { get; set; }
    }
}
