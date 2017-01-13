using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using QJW.Utils;

namespace QJW.WebBase
{
    public class LoginUser
    {
        private static readonly string EncryptionKey = "?L_g.#()";
        private static readonly string CookieName = "authcookie";


        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }

        public long Expires { get; set; }

        public void Login(string domain = null, string path = null)
        {
            var keyName = CookieName;
            var value = GetToken();
            HttpCookie cookie = new HttpCookie(keyName, value);
            cookie.Expires = DateTimeHelper.MSToDateTime(Expires);
            if (string.IsNullOrWhiteSpace(domain))
            {
                cookie.Domain = "";
            }
            else
            {
                cookie.Domain = domain;
            }
            if (string.IsNullOrWhiteSpace(path))
            {
                cookie.Path = "/";
            }
            else
            {
                cookie.Path = path;
            }
            HttpContext.Current.Items[keyName] = this;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public string GetToken()
        {
            var json = JsonConvert.SerializeObject(this);
            var value = EncryptHelper.EncryptString(json, EncryptionKey);
            return value;
        }

        private static LoginUser BuildUser(string keyName)
        {
            //先从请求里取，如果没有，从cookie里取
            string token = null;
            var cookie = HttpContext.Current.Request.Cookies[keyName];
            if (cookie != null)
            {
                token = cookie.Value;
            }
            if (string.IsNullOrEmpty(token))
            {
                token = HttpContext.Current.Request.Headers["apiToken"];
            }
            if (string.IsNullOrEmpty(token))
            {
                token = HttpContext.Current.Request["apiToken"];
            }
            if (token != null && token.Length > 0)
            {
                try
                {
                    var json = EncryptHelper.DecryptString(token, EncryptionKey);
                    var loginuser = JsonConvert.DeserializeObject<LoginUser>(json);
                    if (loginuser != null)
                    {
                        if (DateTimeHelper.MSToDateTime(loginuser.Expires) >= DateTime.Now)
                        {
                            return loginuser;
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }


        public static LoginUser GetUser()
        {
            var keyName = CookieName;
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

        public static void Logout(string domain = null, string path = null)
        {
            var keyName = CookieName;
            HttpCookie cookie = new HttpCookie(keyName, string.Empty);
            cookie.Expires = DateTime.Now.AddMonths(-1);

            cookie.Domain = domain;

            if (string.IsNullOrWhiteSpace(path))
            {
                cookie.Path = "/";
            }
            else
            {
                cookie.Path = path;
            }
            HttpContext.Current.Response.Cookies.Add(cookie);

        }

    }
}
