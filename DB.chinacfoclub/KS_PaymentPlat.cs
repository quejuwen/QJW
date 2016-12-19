using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PaymentPlat
    /// </summary>
    public class KS_PaymentPlat 
    {
        public int? ID { get; set; }
        public string PlatName { get; set; }
        public string Note { get; set; }
        public string AccountID { get; set; }
        public string MD5Key { get; set; }
        public Double? Rate { get; set; }
        public Byte? RateByUser { get; set; }
        public int? OrderID { get; set; }
        public Byte? IsDisabled { get; set; }
        public Byte? IsDefault { get; set; }
    }
}
