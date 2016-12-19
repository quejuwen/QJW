using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PKGD
    /// </summary>
    public class KS_PKGD 
    {
        public int? ID { get; set; }
        public int? PKID { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public string UserIP { get; set; }
        public Byte? Status { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Role { get; set; }
    }
}
