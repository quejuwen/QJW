using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_DownSer
    /// </summary>
    public class KS_DownSer 
    {
        public int? DownID { get; set; }
        public int? ChannelID { get; set; }
        public string DownloadName { get; set; }
        public string DownloadPath { get; set; }
        public Int16? depth { get; set; }
        public Int16? rootid { get; set; }
        public Int16? orders { get; set; }
        public Int16? parentid { get; set; }
        public string strparent { get; set; }
        public Int16? child { get; set; }
        public int? UserGroup { get; set; }
        public int? DownCount { get; set; }
        public Byte? IsDisp { get; set; }
        public Byte? IsLock { get; set; }
        public int? DownPoint { get; set; }
        public Int16? IsOuter { get; set; }
        public string UnionID { get; set; }
        public string selfont { get; set; }
        public int? AllDownHits { get; set; }
        public int? DayDownHits { get; set; }
        public DateTime? HitsTime { get; set; }
    }
}
