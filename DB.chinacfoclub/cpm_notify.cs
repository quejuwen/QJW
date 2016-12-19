using System;

namespace DB.chinacfoclub
{
    public class cpm_notify 
    {
        public int? NotifyId { get; set; }
        public Int16? NotifyClassid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? Addtime { get; set; }
        public int? Target { get; set; }
        public bool? isHidden { get; set; }
        public int? hits { get; set; }
    }
}
