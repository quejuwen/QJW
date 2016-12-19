using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_AskClass
    /// </summary>
    public class KS_AskClass 
    {
        public int? classid { get; set; }
        public string ClassName { get; set; }
        public string Readme { get; set; }
        public int? rootid { get; set; }
        public int? depth { get; set; }
        public int? orders { get; set; }
        public int? parentid { get; set; }
        public string parentstr { get; set; }
        public int? child { get; set; }
        public string Askmaster { get; set; }
        public string c_setting { get; set; }
        public int? AskPendNum { get; set; }
        public int? AskDoneNum { get; set; }
        public int? AskVoteNum { get; set; }
        public int? AskshareNum { get; set; }
    }
}
