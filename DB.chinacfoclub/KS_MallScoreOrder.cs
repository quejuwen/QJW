using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_MallScoreOrder
    /// </summary>
    public class KS_MallScoreOrder 
    {
        public int? ID { get; set; }
        public string OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Amount { get; set; }
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Remark { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? Status { get; set; }
        public Byte? DeliveryType { get; set; }
    }
}
