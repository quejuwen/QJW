using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Log
    /// </summary>
    public class KS_Log 
    {
        public int? ID { get; set; }
        public string UserName { get; set; }
        public Byte? ResultTF { get; set; }
        public string LoginIP { get; set; }
        public DateTime? LoginTime { get; set; }
        public string LoginOS { get; set; }
        public string ScriptName { get; set; }
        public string Description { get; set; }
    }
}
