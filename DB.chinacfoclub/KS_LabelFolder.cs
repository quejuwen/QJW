using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_LabelFolder
    /// </summary>
    public class KS_LabelFolder 
    {
        public string ID { get; set; }
        public string FolderName { get; set; }
        public string TS { get; set; }
        public string Description { get; set; }
        public string ParentID { get; set; }
        public Byte? OrderID { get; set; }
        public Byte? FolderType { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
