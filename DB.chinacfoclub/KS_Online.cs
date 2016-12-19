using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Online
    /// </summary>
    public class KS_Online 
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string identitys { get; set; }
        public string station { get; set; }
        public string ip { get; set; }
        public string browser { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? lastTime { get; set; }
        public string strReferer { get; set; }
    }
}
