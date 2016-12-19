using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Friend
    /// </summary>
    public class KS_Friend 
    {
        public int? ID { get; set; }
        public string Username { get; set; }
        public string Friend { get; set; }
        public DateTime? Addtime { get; set; }
        public Byte? Mod { get; set; }
        public int? Userid { get; set; }
        public string realname { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string QQ { get; set; }
        public string MSN { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public int? flag { get; set; }
        public Byte? Accepted { get; set; }
        public string Message { get; set; }
        public Byte? ShieldDT { get; set; }
    }
}
