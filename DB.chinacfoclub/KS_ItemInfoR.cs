using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ItemInfoR
    /// </summary>
    public class KS_ItemInfoR 
    {
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public int? RelativeID { get; set; }
        public int? RelativeChannelID { get; set; }
        public string RelativeText { get; set; }
    }
}
