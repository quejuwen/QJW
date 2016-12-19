using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShopExpress
    /// </summary>
    public class KS_ShopExpress 
    {
        public int? id { get; set; }
        public string Title { get; set; }
        public string Template { get; set; }
        public string PhotoUrl { get; set; }
        public Byte? Status { get; set; }
        public int? ExpressID { get; set; }
    }
}
