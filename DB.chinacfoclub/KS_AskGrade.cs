using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskGrade
    /// </summary>
    public class KS_AskGrade 
    {
        public int? GradeID { get; set; }
        public string UserTitle { get; set; }
        public int? Score { get; set; }
        public string Ico { get; set; }
        public string ClubPower { get; set; }
        public int? ClubPostNum { get; set; }
        public string color { get; set; }
        public Byte? TypeFlag { get; set; }
        public Byte? Special { get; set; }
    }
}
