using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserLogR
    /// </summary>
    public class KS_UserLogR 
    {
        public int? id { get; set; }
        public int? MsgId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? Type { get; set; }
        public DateTime? transtime { get; set; }
        public string Msg { get; set; }
        public Byte? Status { get; set; }
    }
}
