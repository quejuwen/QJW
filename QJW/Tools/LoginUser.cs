using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace QJW
{
    #region 功能说明
    // 举个例子：一个网站有用户系统、商家系统、网站后台3个系统
    //可以分3个userType, user ,shop , system
    //网站后台一般都有角色，如admin,employee
    //那么网站的角色就有 user,shop,admin,employee,但是admin和employee在一个客户端是不能同时登陆的，所以他们是同一类用户（system）
    #endregion

    public enum UserType
    {
        User,
        Shop,
        System
    }

    [Serializable]
    public class LoginUser
    {
        private static string DESKEY = DateTime.Now.ToString("1234MMdd");
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Roles { get; set; }
        public DateTime Expires { get; set; }

        public readonly static string CookieNamePrefix = "authcookie";

        public void Login(string userType, string domain = null, string path = null)
        {
            var keyName = CookieNamePrefix + userType;
            var json = JsonConvert.SerializeObject(this);
            //var json = CYQ.Data.Tool.JsonHelper.ToJson(this);
            var value = Easp.EncryptString(json, DESKEY);

            HttpCookie cookie = new HttpCookie(keyName, value);
            cookie.Expires = Expires;
            if (!string.IsNullOrWhiteSpace(domain))
            {
                cookie.Domain = domain;
            }
            if (path != null)
            {
                cookie.Path = path;
            }
            HttpContext.Current.Items[keyName] = this;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }


        /// <summary>
        /// 从cookie读取用户信息
        /// </summary>
        /// <param name="cookieName"></param>
        private static LoginUser BuildUser(string keyName)
        {
            var cookie = HttpContext.Current.Request.Cookies[keyName];
            if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            {
                try
                {
                    var json = Easp.DecryptString(cookie.Value, DESKEY);
                    //var loginuser = JsonConvert.DeserializeObject<LoginUser>(json);
                    var loginuser = CYQ.Data.Tool.JsonHelper.ToEntity<LoginUser>(json);
                    if (loginuser != null)
                    {
                        if (loginuser.Expires >= DateTime.Now)
                        {
                            return loginuser;
                        }
                    }
                }
                catch
                {
                    //do nothing
                }
            }
            return null;
        }

        public static LoginUser GetUser(string userType)
        {
            var keyName = CookieNamePrefix + userType;
            if (!HttpContext.Current.Items.Contains(keyName))
            {
                var user = BuildUser(keyName);
                HttpContext.Current.Items[keyName] = user;
                return user;
            }
            else
            {
                return HttpContext.Current.Items[keyName] as LoginUser;
            }
        }

        public static int GetUserID(string userType)
        {
            var user = GetUser(userType);
            if (user != null)
                return user.ID;
            return 0;
        }

        /// <summary>
        /// 退出cookie登录
        /// </summary>
        public static void Logout(string userType)
        {
            var keyName = CookieNamePrefix + userType;

            HttpCookie cookie = new HttpCookie(keyName, string.Empty);
            cookie.Expires = DateTime.Now.AddMonths(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }


    }
}
