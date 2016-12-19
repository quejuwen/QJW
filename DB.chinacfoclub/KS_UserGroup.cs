using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_UserGroup
    /// </summary>
    public class KS_UserGroup 
    {
        public int? ID { get; set; }
        public string GroupName { get; set; }
        public string PowerList { get; set; }
        public string Descript { get; set; }
        public Byte? Type { get; set; }
        public Byte? ChargeType { get; set; }
        public int? GroupPoint { get; set; }
        public int? ValidDays { get; set; }
        public int? PowerType { get; set; }
        public int? FormID { get; set; }
        public Byte? ShowOnReg { get; set; }
        public int? UserType { get; set; }
        public string TemplateFile { get; set; }
        public int? SpaceSize { get; set; }
        public Byte? validtype { get; set; }
        public string validEmail { get; set; }
        public string GroupSetting { get; set; }
        public string modelpower { get; set; }
    }
}
