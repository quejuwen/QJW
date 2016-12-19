using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LogMoney
    /// </summary>
    public class KS_LogMoney 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string ClientName { get; set; }
        public Decimal? Money { get; set; }
        public Decimal? CurrMoney { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public int? MoneyType { get; set; }
        public int? IncomeOrPayOut { get; set; }
        public string OrderID { get; set; }
        public int? PaymentID { get; set; }
        public string Remark { get; set; }
        public DateTime? PayTime { get; set; }
        public DateTime? LogTime { get; set; }
        public string Inputer { get; set; }
        public string IP { get; set; }
        public int? Times { get; set; }
    }
}
