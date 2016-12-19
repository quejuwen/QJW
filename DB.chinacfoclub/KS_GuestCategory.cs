using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_GuestCategory
    /// </summary>
    public class KS_GuestCategory 
    {
        public int? CategoryId { get; set; }
        public int? BoardID { get; set; }
        public int? OrderID { get; set; }
        public Byte? Status { get; set; }
        public string CategoryName { get; set; }
        public string ICO { get; set; }
    }
}
