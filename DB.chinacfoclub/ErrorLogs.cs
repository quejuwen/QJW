using System;

namespace DB.chinacfoclub
{
    public class ErrorLogs 
    {
        public int? ID { get; set; }
        public string PageUrl { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? LogTime { get; set; }
    }
}
