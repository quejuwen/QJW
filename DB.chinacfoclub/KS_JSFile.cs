using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_JSFile
    /// </summary>
    public class KS_JSFile 
    {
        public string JSID { get; set; }
        public string JSName { get; set; }
        public string JSFileName { get; set; }
        public string JSConfig { get; set; }
        public Byte? JSType { get; set; }
        public DateTime? AddDate { get; set; }
        public string Description { get; set; }
        public Byte? OrderID { get; set; }
        public string FolderID { get; set; }
    }
}
