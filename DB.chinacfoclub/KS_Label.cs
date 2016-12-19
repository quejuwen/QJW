using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Label
    /// </summary>
    public class KS_Label 
    {
        public string ID { get; set; }
        public string LabelName { get; set; }
        public string LabelContent { get; set; }
        public string Description { get; set; }
        public string FolderID { get; set; }
        public Byte? OrderID { get; set; }
        public Byte? LabelType { get; set; }
        public Byte? LabelFlag { get; set; }
        public DateTime? AddDate { get; set; }
        public string FileName { get; set; }
    }
}
