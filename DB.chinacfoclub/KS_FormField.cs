using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_FormField
    /// </summary>
    public class KS_FormField 
    {
        public int? FieldID { get; set; }
        public int? ItemID { get; set; }
        public string Title { get; set; }
        public string FieldName { get; set; }
        public string Tips { get; set; }
        public Byte? FieldType { get; set; }
        public string DefaultValue { get; set; }
        public string Options { get; set; }
        public Byte? MustFillTF { get; set; }
        public Byte? ShowOnForm { get; set; }
        public int? OrderID { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string AllowFileExt { get; set; }
        public int? MaxFileSize { get; set; }
        public int? Step { get; set; }
        public string ParentFieldName { get; set; }
        public int? ShowUnit { get; set; }
        public string UnitOptions { get; set; }
        public Byte? ShowOnManage { get; set; }
        public int? MaxLength { get; set; }
    }
}
