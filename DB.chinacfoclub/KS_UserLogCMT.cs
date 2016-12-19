using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserLogCMT
    /// </summary>
    public class KS_UserLogCMT 
    {
        public int? id { get; set; }
        public int? userid { get; set; }
        public string username { get; set; }
        public int? msgid { get; set; }
        public string content { get; set; }
        public DateTime? adddate { get; set; }
        public Byte? status { get; set; }
    }
}
