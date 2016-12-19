using System;

namespace DB.chinacfoclub
{
    public class guest 
    {
        public int? id { get; set; }
        public string guestname { get; set; }
        public string from { get; set; }
        public string face { get; set; }
        public string guestcontent { get; set; }
        public string guestreply { get; set; }
        public string guestdate { get; set; }
        public string oicq { get; set; }
        public string email { get; set; }
        public string homepage { get; set; }
        public string ip { get; set; }
        public string replyer { get; set; }
        public int? depart { get; set; }
        public int? subdepart { get; set; }
        public Int16? signde { get; set; }
        public bool? flag { get; set; }
        public bool? IsCommon { get; set; }
        public bool? IsDelete { get; set; }
    }
}
