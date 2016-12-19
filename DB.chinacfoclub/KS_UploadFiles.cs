using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UploadFiles
    /// </summary>
    public class KS_UploadFiles 
    {
        public int? ID { get; set; }
        public int? ChannelID { get; set; }
        public int? InfoID { get; set; }
        public string FileName { get; set; }
        public Byte? IsAnnex { get; set; }
        public string UserName { get; set; }
        public int? ClassID { get; set; }
        public int? Hits { get; set; }
        public string Title { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
