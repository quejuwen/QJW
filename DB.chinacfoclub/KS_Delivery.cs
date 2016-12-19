using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Delivery
    /// </summary>
    public class KS_Delivery 
    {
        public int? Typeid { get; set; }
        public string TypeName { get; set; }
        public int? orderid { get; set; }
        public Byte? isDefault { get; set; }
        public int? ExpressID { get; set; }
        public Single? c_fee { get; set; }
        public Single? w_fee { get; set; }
        public string tocity { get; set; }
        public Single? fweight { get; set; }
        public Single? carriage { get; set; }
        public Single? weight { get; set; }
        public string DefaultCity { get; set; }
    }
}
