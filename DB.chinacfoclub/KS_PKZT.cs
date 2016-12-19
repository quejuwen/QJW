using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PKZT
    /// </summary>
    public class KS_PKZT 
    {
        public int? id { get; set; }
        public string ClassID { get; set; }
        public string Title { get; set; }
        public string ZFTips { get; set; }
        public string FFTips { get; set; }
        public int? ZFVotes { get; set; }
        public int? FFVotes { get; set; }
        public int? SFVotes { get; set; }
        public string NewsLink { get; set; }
        public Byte? TimeLimit { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Status { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? LoginTF { get; set; }
        public Byte? OnceTF { get; set; }
        public Byte? VerifyTF { get; set; }
    }
}
