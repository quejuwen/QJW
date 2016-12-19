using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_PaymentType
    /// </summary>
    public class KS_PaymentType 
    {
        public int? Typeid { get; set; }
        public string TypeName { get; set; }
        public Double? Discount { get; set; }
        public int? orderid { get; set; }
        public Byte? isDefault { get; set; }
    }
}
