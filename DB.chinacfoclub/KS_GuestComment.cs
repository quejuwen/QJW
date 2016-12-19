using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GuestComment
    /// </summary>
    public class KS_GuestComment 
    {
        public int? ID { get; set; }
        public int? tid { get; set; }
        public int? pid { get; set; }
        public string userface { get; set; }
        public string username { get; set; }
        public int? userid { get; set; }
        public string comment { get; set; }
        public DateTime? adddate { get; set; }
        public Byte? orderid { get; set; }
        public int? Prestige { get; set; }
    }
}
