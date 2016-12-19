using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Special
    /// </summary>
    public class KS_Special 
    {
        public int? SpecialID { get; set; }
        public string ID { get; set; }
        public int? ClassID { get; set; }
        public string SpecialName { get; set; }
        public string SpecialEName { get; set; }
        public string PhotoUrl { get; set; }
        public string TemplateID { get; set; }
        public string SpecialNote { get; set; }
        public DateTime? SpecialAddDate { get; set; }
        public string FsoSpecialIndex { get; set; }
        public string Creater { get; set; }
        public string MetaKey { get; set; }
        public string MetaDescript { get; set; }
    }
}
