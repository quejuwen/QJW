using System;

namespace DB.chinacfoclub
{
    /// <summary>
    /// KS_User
    /// </summary>
    public class KS_User 
    {
        public int? UserID { get; set; }
        public int? GroupID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Email { get; set; }
        public string RealName { get; set; }
        public string Sex { get; set; }
        public DateTime? birthday { get; set; }
        public string IDCard { get; set; }
        public string OfficeTel { get; set; }
        public string HomeTel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string HomePage { get; set; }
        public string QQ { get; set; }
        public string ICQ { get; set; }
        public string MSN { get; set; }
        public string UC { get; set; }
        public string UserFace { get; set; }
        public string Sign { get; set; }
        public int? Privacy { get; set; }
        public string CheckNum { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string LastLoginIP { get; set; }
        public int? LoginTimes { get; set; }
        public int? ChargeType { get; set; }
        public DateTime? BeginDate { get; set; }
        public Decimal? Money { get; set; }
        public int? EDays { get; set; }
        public int? Score { get; set; }
        public Single? Point { get; set; }
        public int? Locked { get; set; }
        public string RndPassword { get; set; }
        public int? UserType { get; set; }
        public string Wap { get; set; }
        public string AllianceUser { get; set; }
        public int? PostNum { get; set; }
        public Byte? IsOnline { get; set; }
        public string GradeTitle { get; set; }
        public int? GradeID { get; set; }
        public int? UserCardID { get; set; }
        public Byte? LockOnClub { get; set; }
        public int? ClubGradeID { get; set; }
        public Byte? ClubSpecialPower { get; set; }
        public int? Prestige { get; set; }
        public int? BestTopicNum { get; set; }
        public string Medal { get; set; }
        public string QQopenid { get; set; }
        public string QQtoken { get; set; }
        public string SinaToken { get; set; }
        public string alipayID { get; set; }
        public string SinaId { get; set; }
        public Byte? IsRz { get; set; }
        public Byte? IsSFZRZ { get; set; }
        public Byte? IsMobileRZ { get; set; }
        public Byte? IsEmailRZ { get; set; }
        public string SFZPhotoUrl { get; set; }
        public DateTime? LastRzdate { get; set; }
        public int? ScoreHasUse { get; set; }
        public string Synchronization { get; set; }
        public int? IsApi { get; set; }
        public int? MsgNum { get; set; }
        public int? FansNum { get; set; }
        public int? AttentionNum { get; set; }
        public DateTime? LastPostWeiboTime { get; set; }
        public int? LastPostWeiBoID { get; set; }
        public string MyLabel { get; set; }
    }
}
