using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Class
    /// </summary>
    public class KS_Class 
    {
        public string ID { get; set; }
        public int? ClassID { get; set; }
        public int? ClassType { get; set; }
        public string FolderName { get; set; }
        public string TS { get; set; }
        public string TN { get; set; }
        public Byte? TJ { get; set; }
        public string Folder { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FolderTemplateID { get; set; }
        public string FolderFsoIndex { get; set; }
        public string TemplateID { get; set; }
        public string FnameType { get; set; }
        public Byte? FsoType { get; set; }
        public string FolderDomain { get; set; }
        public int? FolderOrder { get; set; }
        public Int16? ChannelID { get; set; }
        public Byte? TopFlag { get; set; }
        public Byte? DelTF { get; set; }
        public DateTime? DelDate { get; set; }
        public Int16? CommentTF { get; set; }
        public string AllowArrGroupID { get; set; }
        public Int16? ClassPurview { get; set; }
        public string DefaultArrGroupID { get; set; }
        public Int16? DefaultReadPoint { get; set; }
        public Int16? DefaultChargeType { get; set; }
        public Int16? DefaultPitchTime { get; set; }
        public Int16? DefaultReadTimes { get; set; }
        public Int16? DefaultDividePercent { get; set; }
        public string ClassBasicInfo { get; set; }
        public string ClassDefineContent { get; set; }
        public Byte? WapSwitch { get; set; }
        public int? Root { get; set; }
        public int? Child { get; set; }
        public string AdminPurview { get; set; }
        public string WapFolderTemplateID { get; set; }
        public string WapSpecialTemplateID { get; set; }
        public string WapTemplateID { get; set; }
        public Byte? PubTf { get; set; }
        public int? MailTf { get; set; }
        public int? FilterTF { get; set; }
        public Byte? MapTF { get; set; }
    }
}
