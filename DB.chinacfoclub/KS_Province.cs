using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Province
    /// </summary>
    public class KS_Province 
    {
        public int? ID { get; set; }
        public int? Parentid { get; set; }
        public string e_City { get; set; }
        public string City { get; set; }
        public int? OrderID { get; set; }
        public int? FilterTF { get; set; }
    }
}
