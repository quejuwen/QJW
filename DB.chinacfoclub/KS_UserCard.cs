using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserCard
    /// </summary>
    public class KS_UserCard 
    {
        public int? ID { get; set; }
        public string CardNum { get; set; }
        public string CardPass { get; set; }
        public Decimal? Money { get; set; }
        public int? ValidNum { get; set; }
        public int? ValidUnit { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UseDate { get; set; }
        public string UserName { get; set; }
        public int? IsUsed { get; set; }
        public int? IsSale { get; set; }
        public string GroupName { get; set; }
        public Byte? CardType { get; set; }
        public string AllowGroupID { get; set; }
        public int? GroupID { get; set; }
        public int? ExpireGroupID { get; set; }
    }
}
