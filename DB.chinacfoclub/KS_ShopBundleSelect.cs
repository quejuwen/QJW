using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopBundleSelect
    /// </summary>
    public class KS_ShopBundleSelect 
    {
        public int? ID { get; set; }
        public int? ProID { get; set; }
        public int? Pid { get; set; }
        public string AttributeCart { get; set; }
        public int? Amount { get; set; }
        public string UserName { get; set; }
        public DateTime? AddDate { get; set; }
        public Decimal? Price { get; set; }
    }
}
