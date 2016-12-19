using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_BlogSkin
    /// </summary>
    public class KS_BlogSkin 
    {
        public int? id { get; set; }
        public int? templateid { get; set; }
        public int? IsDefault { get; set; }
        public string UserName { get; set; }
        public string PhotoName { get; set; }
        public string PhotoUrl { get; set; }
        public string LinkUrl { get; set; }
        public string Descript { get; set; }
        public Byte? IsBg { get; set; }
        public int? OrderID { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? ModifyLink { get; set; }
    }
}
