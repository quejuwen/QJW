using System;

namespace DB.chinacfoclub
{
    public class BookOrder 
    {
        public int? ID { get; set; }
        public int? GoodsId { get; set; }
        public int? Amount { get; set; }
        public Single? Price { get; set; }
        public Single? Money { get; set; }
        public string Payment { get; set; }
        public string AddPerson { get; set; }
        public string AddDesc { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsPay { get; set; }
        public string PayPerson { get; set; }
        public string PayDesc { get; set; }
        public DateTime? PayDate { get; set; }
        public bool? IsShip { get; set; }
        public string ShipPerson { get; set; }
        public string ShipDesc { get; set; }
        public DateTime? ShipDate { get; set; }
        public bool? IsDeliver { get; set; }
        public string DeliverPerson { get; set; }
        public string DeliverDesc { get; set; }
        public DateTime? DeliverDate { get; set; }
        public bool? IsDel { get; set; }
        public int? DepartId { get; set; }
    }
}
