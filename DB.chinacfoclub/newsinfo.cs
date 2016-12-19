using System;

namespace DB.chinacfoclub
{
    public class newsinfo 
    {
        public int? newsid { get; set; }
        public string newsclassify { get; set; }
        public string newstitle { get; set; }
        public string newscontent { get; set; }
        public DateTime? newstime { get; set; }
        public string newsowner { get; set; }
        public string newsdesc { get; set; }
    }
}
