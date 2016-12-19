using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_BlogTemplate
    /// </summary>
    public class KS_BlogTemplate 
    {
        public int? ID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateMain { get; set; }
        public string TemplateSub { get; set; }
        public string TemplateAuthor { get; set; }
        public string TemplatePic { get; set; }
        public string IsDefault { get; set; }
        public int? flag { get; set; }
        public int? UserTag { get; set; }
        public int? ShareTag { get; set; }
        public string GroupID { get; set; }
    }
}
