using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_MallScore
    /// </summary>
    public class KS_MallScore 
    {
        public int? ID { get; set; }
        public string ProductName { get; set; }
        public string PhotoUrl { get; set; }
        public int? Quantity { get; set; }
        public int? Score { get; set; }
        public string Intro { get; set; }
        public int? Hits { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? AddDate { get; set; }
        public string GroupID { get; set; }
        public Byte? Recommend { get; set; }
        public Byte? Status { get; set; }
        public string Inputer { get; set; }
    }
}
