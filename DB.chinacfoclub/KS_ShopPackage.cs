using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopPackage
    /// </summary>
    public class KS_ShopPackage 
    {
        public int? ID { get; set; }
        public string PackName { get; set; }
        public string PhotoURL { get; set; }
        public string BigPhoto { get; set; }
        public int? Num { get; set; }
        public Byte? PackType { get; set; }
        public Single? Discount { get; set; }
        public Byte? Status { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }
        public string TemplateID { get; set; }
    }
}
