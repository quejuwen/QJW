using System;

namespace DB.chinacfoclub
{
    public class Study 
    {
        public int? StudyId { get; set; }
        public string StudyNo { get; set; }
        public string StudyClass { get; set; }
        public int? StudyDays { get; set; }
        public bool? StudyAudit { get; set; }
        public string StudyDemo { get; set; }
        public int? StudyPrice { get; set; }
        public int? depart { get; set; }
        public int? subdepart { get; set; }
        public DateTime? addtime { get; set; }
        public int? hits { get; set; }
        public bool? flag { get; set; }
        public int? auditPrice { get; set; }
        public int? departid { get; set; }
        public bool? isActive { get; set; }
        public int? orderflag { get; set; }
        public int? auditPrice1 { get; set; }
        public int? auditPrice2 { get; set; }
        public int? auditPrice3 { get; set; }
        public int? auditPrice4 { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsCpmqa { get; set; }
    }
}
