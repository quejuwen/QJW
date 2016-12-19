using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PromotedPlan
    /// </summary>
    public class KS_PromotedPlan 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string UserIP { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComeUrl { get; set; }
        public int? Score { get; set; }
        public string AllianceUser { get; set; }
    }
}
