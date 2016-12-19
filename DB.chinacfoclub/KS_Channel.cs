using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_Channel
    /// </summary>
    public class KS_Channel 
    {
        public int? ChannelID { get; set; }
        public string ChannelName { get; set; }
        public string ModelEname { get; set; }
        public int? FsoHtmlTF { get; set; }
        public string FsoFolder { get; set; }
        public Int16? FsoListNum { get; set; }
        public int? FsoClassListRule { get; set; }
        public string FsoClassPreTag { get; set; }
        public string FsoContentRule { get; set; }
        public int? InfoVerificTF { get; set; }
        public int? VerificCommentTF { get; set; }
        public Byte? UserTF { get; set; }
        public Byte? UpFilesTF { get; set; }
        public string UpFilesDir { get; set; }
        public int? UpFilesSize { get; set; }
        public string AllowUpPhotoType { get; set; }
        public string AllowUpFlashType { get; set; }
        public string AllowUpMediaType { get; set; }
        public string AllowUpRealType { get; set; }
        public string AllowUpOtherType { get; set; }
        public int? CollectTF { get; set; }
        public Byte? ChannelStatus { get; set; }
        public int? RefreshFlag { get; set; }
        public int? UserAddMoney { get; set; }
        public int? UserAddPoint { get; set; }
        public int? UserAddScore { get; set; }
        public int? UserUpFilesTF { get; set; }
        public string UserUpFilesDir { get; set; }
        public int? UserSelectFilesTF { get; set; }
        public int? CommentVF { get; set; }
        public int? CommentLen { get; set; }
        public string ChannelTable { get; set; }
        public string FieldBit { get; set; }
        public string ItemName { get; set; }
        public string ItemUnit { get; set; }
        public string Descript { get; set; }
        public Int16? BasicType { get; set; }
        public int? MaxPerPage { get; set; }
        public string CommentTemplate { get; set; }
        public string SearchTemplate { get; set; }
        public Byte? ChargeType { get; set; }
        public int? AnnexPoint { get; set; }
        public Byte? DiggByVisitor { get; set; }
        public Byte? DiggByIP { get; set; }
        public Byte? DiggRepeat { get; set; }
        public int? DiggPerTimes { get; set; }
        public Byte? UserClassStyle { get; set; }
        public Byte? UserEditTF { get; set; }
        public Byte? WapSwitch { get; set; }
        public string ThumbnailsConfig { get; set; }
        public int? LatestNewDay { get; set; }
        public Byte? StaticTF { get; set; }
        public string WapSearchTemplate { get; set; }
        public int? PubTimeLimit { get; set; }
        public string ModelIco { get; set; }
        public string ModelShortName { get; set; }
    }
}
