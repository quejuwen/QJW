using System;

namespace DB.chinacfoclub
{
    public class StSign 
    {
        public int? SignId { get; set; }
        public int? StUnid { get; set; }
        public int? StudyId { get; set; }
        public string CertCode { get; set; }
        public string Speciality { get; set; }
        public string Grade { get; set; }
        public string ExamCode { get; set; }
        public DateTime? ExamDate { get; set; }
        public string ExamAddr { get; set; }
        public string LunWen { get; set; }
        public DateTime? DabianDate { get; set; }
        public string DabianAddr { get; set; }
        public string Payment { get; set; }
        public DateTime? Addtime { get; set; }
        public string AddOperator { get; set; }
        public bool? SignState { get; set; }
        public DateTime? SignTime { get; set; }
        public string SignOperator { get; set; }
        public bool? Audit { get; set; }
        public DateTime? AuditTime { get; set; }
        public string AuditOperator { get; set; }
        public bool? Cert { get; set; }
        public DateTime? CertTime { get; set; }
        public string CertOperator { get; set; }
        public bool? flag { get; set; }
        public int? cj1 { get; set; }
        public int? cj2 { get; set; }
        public int? cj3 { get; set; }
        public int? cj4 { get; set; }
        public int? DepartId { get; set; }
        public int? LunwenId { get; set; }
        public bool? LunwenAudit { get; set; }
        public bool? IsLock { get; set; }
        public string SelectLessonid { get; set; }
        public int? NianJian { get; set; }
        public DateTime? NianJianDate { get; set; }
        public string NianJianOperator { get; set; }
        public DateTime? NianJianCertTime { get; set; }
        public string NianJianDesc { get; set; }
        public int? RegId { get; set; }
        public int? Depart { get; set; }
        public int? SubDepart { get; set; }
        public int? SignDe { get; set; }
        public int? SignDeFlag { get; set; }
        /// <summary>
        /// ÉêÇë±íÃû³Æ
        /// </summary>
        public string DownFileName { get; set; }
    }
}
