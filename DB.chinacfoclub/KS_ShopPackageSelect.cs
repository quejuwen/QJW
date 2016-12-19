using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopPackageSelect
    /// </summary>
    public class KS_ShopPackageSelect 
    {
        public int? ID { get; set; }
        public int? ProID { get; set; }
        public int? PackID { get; set; }
        public string AttributeCart { get; set; }
        public int? Amount { get; set; }
        public string UserName { get; set; }
        public DateTime? AddDate { get; set; }
        public int? AttrID { get; set; }
    }
}
