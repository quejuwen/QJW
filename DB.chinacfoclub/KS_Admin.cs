using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Admin
    /// </summary>
    public class KS_Admin 
    {
        public int? AdminID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PrUserName { get; set; }
        public string RealName { get; set; }
        public string Sex { get; set; }
        public string TelPhone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime? AddDate { get; set; }
        public string LastLoginIP { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime? LastLogoutTime { get; set; }
        public int? LoginTimes { get; set; }
        public Byte? Locked { get; set; }
        public string SuperTF { get; set; }
        public int? GroupID { get; set; }
    }
}
