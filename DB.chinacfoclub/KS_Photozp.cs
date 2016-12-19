using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Photozp
    /// </summary>
    public class KS_Photozp 
    {
        public int? ID { get; set; }
        public int? xcid { get; set; }
        public string Title { get; set; }
        public string Descript { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public string PhotoSize { get; set; }
        public int? hits { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
