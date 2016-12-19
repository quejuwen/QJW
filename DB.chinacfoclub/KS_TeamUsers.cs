using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_TeamUsers
    /// </summary>
    public class KS_TeamUsers 
    {
        public int? id { get; set; }
        public int? TeamID { get; set; }
        public string username { get; set; }
        public string reason { get; set; }
        public int? power { get; set; }
        public int? status { get; set; }
        public DateTime? Applydate { get; set; }
        public DateTime? Adddate { get; set; }
    }
}
