using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskFavorite
    /// </summary>
    public class KS_AskFavorite 
    {
        public int? favorid { get; set; }
        public string UserName { get; set; }
        public int? TopicID { get; set; }
        public DateTime? FavorTime { get; set; }
        public Byte? Typeflag { get; set; }
    }
}
