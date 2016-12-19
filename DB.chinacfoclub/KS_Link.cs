using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Link
    /// </summary>
    public class KS_Link 
    {
        public int? LinkID { get; set; }
        public int? FolderID { get; set; }
        public string SiteName { get; set; }
        public string WebMaster { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string Password { get; set; }
        public int? LinkType { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public int? Hits { get; set; }
        public int? Recommend { get; set; }
        public DateTime? AddDate { get; set; }
        public Byte? Locked { get; set; }
        public int? Verific { get; set; }
        public int? OrderID { get; set; }
    }
}
