using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Utils
{
    public class ConfigHelper
    {
        /// <summary>
        /// 返回指定name的ConnectionStrings节点的ConnectionString，
        /// 如果找不到则返回null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConnString(string name)
        {
            var settings = System.Configuration.ConfigurationManager.ConnectionStrings[name];
            return settings == null ? null : settings.ConnectionString;
        }

        /// <summary>
        /// 返回指定key的AppSettings节点的value，
        /// 如果找不到则返回null
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AppSetting(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }
    }
}
