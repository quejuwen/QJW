using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Field
    /// </summary>
    public class KS_Field 
    {
        public int? FieldID { get; set; }
        public int? ChannelID { get; set; }
        public string FieldName { get; set; }
        public string Title { get; set; }
        public string Tips { get; set; }
        public Byte? FieldType { get; set; }
        public string DefaultValue { get; set; }
        public string Options { get; set; }
        public Byte? MustFillTF { get; set; }
        public Byte? ShowOnForm { get; set; }
        public Byte? ShowOnUserForm { get; set; }
        public int? OrderID { get; set; }
        public string AllowFileExt { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? MaxFileSize { get; set; }
        public string EditorType { get; set; }
        public Byte? ShowUnit { get; set; }
        public string UnitOptions { get; set; }
        public string ParentFieldName { get; set; }
        public int? MaxLength { get; set; }
        public int? ShowOnClubForm { get; set; }
    }
}
