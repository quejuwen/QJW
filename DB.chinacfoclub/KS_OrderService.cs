using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_OrderService
    /// </summary>
    public class KS_OrderService 
    {
        public int? id { get; set; }
        public int? orderid { get; set; }
        public string content { get; set; }
        public DateTime? adddate { get; set; }
        public string qsr { get; set; }
    }
}
