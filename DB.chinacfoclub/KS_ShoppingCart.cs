using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ShoppingCart
    /// </summary>
    public class KS_ShoppingCart 
    {
        public int? cartid { get; set; }
        public int? proid { get; set; }
        public string attr { get; set; }
        public int? amount { get; set; }
        public string username { get; set; }
        public DateTime? adddate { get; set; }
        public int? flag { get; set; }
        public int? attrid { get; set; }
    }
}
