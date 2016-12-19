using System;

namespace DB.chinacfoclub
{
    public class LessonRemark 
    {
        public int? RemarkId { get; set; }
        public int? LessonId { get; set; }
        public int? StUnid { get; set; }
        public string Remark { get; set; }
        public bool? flag { get; set; }
    }
}
