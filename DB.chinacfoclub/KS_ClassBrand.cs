using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_ClassBrand
    /// </summary>
    public class KS_ClassBrand 
    {
        public int? ID { get; set; }
        public string BrandName { get; set; }
        public int? OrderID { get; set; }
        public Byte? ShowInTop { get; set; }
        public string PhotoUrl { get; set; }
        public Byte? Recommend { get; set; }
        public string Intro { get; set; }
        public string firstAlphabet { get; set; }
        public string BrandEName { get; set; }
    }
}
