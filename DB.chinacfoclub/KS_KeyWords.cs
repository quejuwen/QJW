using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_KeyWords
    /// </summary>
    public class KS_KeyWords 
    {
        public int? ID { get; set; }
        public string KeyText { get; set; }
        public DateTime? AddDate { get; set; }
        public int? hits { get; set; }
        public DateTime? LastUseTime { get; set; }
        public Byte? IsSearch { get; set; }
    }
}
