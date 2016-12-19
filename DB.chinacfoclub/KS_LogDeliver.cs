using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogDeliver
    /// </summary>
    public class KS_LogDeliver 
    {
        public int? ID { get; set; }
        public string OrderID { get; set; }
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public string Inputer { get; set; }
        public string HandlerName { get; set; }
        public DateTime? DeliverDate { get; set; }
        public int? DeliverType { get; set; }
        public string ExpressCompany { get; set; }
        public string ExpressNumber { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
    }
}
