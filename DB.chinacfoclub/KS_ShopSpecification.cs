using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopSpecification
    /// </summary>
    public class KS_ShopSpecification 
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public Byte? ShowType { get; set; }
        public string SValue { get; set; }
        public int? orderid { get; set; }
    }
}
