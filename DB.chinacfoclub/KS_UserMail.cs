using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserMail
    /// </summary>
    public class KS_UserMail 
    {
        public int? id { get; set; }
        public string Email { get; set; }
        public string ActiveCode { get; set; }
        public DateTime? AddDate { get; set; }
        public string UserName { get; set; }
        public Byte? IsUser { get; set; }
        public string ClassID { get; set; }
        public Byte? ActiveTF { get; set; }
    }
}
