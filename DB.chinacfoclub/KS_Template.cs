using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Template
    /// </summary>
    public class KS_Template 
    {
        public int? TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateFileName { get; set; }
        public string FsoFileName { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
