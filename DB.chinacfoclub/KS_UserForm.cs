using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserForm
    /// </summary>
    public class KS_UserForm 
    {
        public int? ID { get; set; }
        public string FormName { get; set; }
        public string FormField { get; set; }
        public DateTime? AddDate { get; set; }
        public string Template { get; set; }
        public string Note { get; set; }
        public string WapTemplate { get; set; }
    }
}
