using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserRecord
    /// </summary>
    public class KS_UserRecord 
    {
        public int? ID { get; set; }
        public string UserIP { get; set; }
        public int? flag { get; set; }
        public string note { get; set; }
        public DateTime? adddate { get; set; }
        public int? userid { get; set; }
        public string UserName { get; set; }
    }
}
