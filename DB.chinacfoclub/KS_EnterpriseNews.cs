using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_EnterpriseNews
    /// </summary>
    public class KS_EnterpriseNews 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public int? ClassID { get; set; }
        public string AddDate { get; set; }
        public string Content { get; set; }
        public int? Status { get; set; }
        public int? BigClassID { get; set; }
        public int? SmallClassID { get; set; }
        public int? UserID { get; set; }
        public string Domain { get; set; }
    }
}
