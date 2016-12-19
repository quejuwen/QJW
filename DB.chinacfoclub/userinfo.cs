using System;

namespace DB.chinacfoclub
{
    public class userinfo 
    {
        public int? userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int? roleid { get; set; }
        public string telephone { get; set; }
        public string usersex { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public DateTime? logintime { get; set; }
        public DateTime? createtime { get; set; }
    }
}
