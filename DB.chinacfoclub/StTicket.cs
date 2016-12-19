using System;

namespace DB.chinacfoclub
{
    public class StTicket 
    {
        public int? TicketId { get; set; }
        public int? StUnid { get; set; }
        public int? LessonId { get; set; }
        public Int16? TicketNum { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? TotalPrice { get; set; }
        public string Payment { get; set; }
        public bool? SignState { get; set; }
        public bool? SignFlag { get; set; }
        public DateTime? Addtime { get; set; }
        public Int16? Depart { get; set; }
        public Int16? SubDepart { get; set; }
        public bool? flag { get; set; }
        public Int16? SignDe { get; set; }
        public Int16? departid { get; set; }
    }
}
