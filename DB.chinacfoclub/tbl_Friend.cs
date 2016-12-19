using System;

namespace DB.chinacfoclub
{
    public class tbl_Friend 
    {
        public int? ID { get; set; }
        public int? FriendId { get; set; }
        public string FriendUser { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsDel { get; set; }
        public bool? IsFollowMe { get; set; }
        public bool? IsAddFriend { get; set; }
        public bool? IsAccepted { get; set; }
        public int? FansCount { get; set; }
        public int? FollowCount { get; set; }
        public int? FriendCount { get; set; }
        public int? AcenterId { get; set; }
        public string LoginUser { get; set; }
        public bool? IsFollow { get; set; }
    }
}
