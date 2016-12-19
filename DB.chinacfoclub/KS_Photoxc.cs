using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Photoxc
    /// </summary>
    public class KS_Photoxc 
    {
        public int? ID { get; set; }
        public string XCName { get; set; }
        public string Descript { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public int? XPS { get; set; }
        public int? Hits { get; set; }
        public int? Score { get; set; }
        public DateTime? AddDate { get; set; }
        public int? xcdx { get; set; }
        public int? classid { get; set; }
        public string PhotoUrl { get; set; }
        public int? Flag { get; set; }
        public string PassWord { get; set; }
        public int? Recommend { get; set; }
        public int? status { get; set; }
    }
}
