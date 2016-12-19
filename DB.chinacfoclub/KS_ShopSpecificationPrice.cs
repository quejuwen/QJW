using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopSpecificationPrice
    /// </summary>
    public class KS_ShopSpecificationPrice 
    {
        public int? id { get; set; }
        public string itemNo { get; set; }
        public int? proid { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public Decimal? price { get; set; }
        public int? amount { get; set; }
        public int? weight { get; set; }
    }
}
