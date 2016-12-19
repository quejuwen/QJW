using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserClass
    /// </summary>
    public class KS_UserClass 
    {
        public int? ClassID { get; set; }
        public string UserName { get; set; }
        public string ClassName { get; set; }
        public string Descript { get; set; }
        public DateTime? AddDate { get; set; }
        public int? OrderID { get; set; }
        public int? TypeID { get; set; }
    }
}
