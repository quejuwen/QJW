using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogInvoice
    /// </summary>
    public class KS_LogInvoice 
    {
        public int? ID { get; set; }
        public string OrderID { get; set; }
        public string UserName { get; set; }
        public string ClientName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceNum { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceContent { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public Decimal? MoneyTotal { get; set; }
        public string HandlerName { get; set; }
        public string Inputer { get; set; }
        public DateTime? InputTime { get; set; }
    }
}
