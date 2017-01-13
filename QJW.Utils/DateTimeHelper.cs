using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Utils
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 日期转换成unix时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            dateTime = dateTime.ToUniversalTime();
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((dateTime - start).TotalMilliseconds);
        }

        /// <summary>
        /// unix时间戳转换成日期
        /// </summary>
        /// <param name="timestamp">时间戳（秒）</param>
        /// <returns></returns>
        public static DateTime UnixTimestampToDateTime(long timestamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return start.AddMilliseconds(timestamp).ToLocalTime();
        }


        /// <summary>
        /// 日期转换成 毫秒
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DateTimeToMS(DateTime dateTime)
        {
            dateTime = dateTime.ToUniversalTime();
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((dateTime - start).TotalMilliseconds);
        }

        /// <summary>
        /// 毫秒转换成日期
        /// </summary>
        /// <param name="timestamp">时间戳（毫秒）</param>
        /// <returns></returns>
        public static DateTime MSToDateTime(long ms)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return start.AddMilliseconds(ms).ToLocalTime();
        }



        public static readonly DateTime SqlMinDateTime = new DateTime(1753, 1, 1);
        public static readonly DateTime SqlMaxDateTime = new DateTime(9999, 12, 31, 23, 59, 59);

        public static readonly DateTime MySqlMinValue = new DateTime(1753, 1, 1);
        public static readonly DateTime MySqlMaxValue = new DateTime(2099, 12, 31);

        public static string GetString(this DateTime? dt, string format = "yyyy-MM-dd HH:mm", string defaultValue = "")
        {
            return dt.HasValue ? dt.Value.ToString(format) : defaultValue;
        }
        public static string GetString(this DateTime dt, string format = "yyyy-MM-dd HH:mm")
        {
            return dt.ToString(format);
        }
        public static string GetString(this TimeSpan ts, string format = @"hh\:mm")
        {
            return ts.ToString(format);
        }
        public static string GetString(this TimeSpan? ts, string format = @"hh\:mm", string defaultValue = "")
        {
            return ts.HasValue ? ts.Value.ToString(format) : defaultValue;
        }

        public static string GetShortString(this DateTime dt)
        {
            return dt.GetString("yyyy-MM-dd");
        }
        public static string GetShortString(this DateTime? dt, string defaultValue = "")
        {
            return dt.GetString("yyyy-MM-dd", defaultValue);
        }

        public static DateTime? GetDateTime(this string strDate)
        {
            if (string.IsNullOrEmpty(strDate)) return null;
            DateTime dt;
            if (DateTime.TryParse(strDate, out dt))
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public static string ToFriendlyString(DateTime dt)
        {
            var span = DateTime.Now - dt;

            if (span.TotalSeconds < 60)
            {
                return Math.Round((span.TotalSeconds < 5 ? 5 : span.TotalSeconds), 0) + "秒钟前";
            }
            if (span.TotalMinutes < 60)
            {
                return Math.Round(span.TotalMinutes, 0) + "分钟前";
            }
            if (span.TotalHours < 5)
            {
                if (span.Minutes > 0)
                {
                    return span.Hours + "小时" + span.Minutes + "分钟前";
                }
                else
                {
                    return span.Hours + "小时前";
                }
            }
            if (span.TotalDays < 1 && DateTime.Now.Day == dt.Day)
            {
                return "今天 " + dt.ToString("HH:mm") + "";
            }
            if (span.TotalDays < 1 && DateTime.Now.Day > dt.Day)
            {
                return "昨天 " + dt.ToString("HH:mm") + "";
            }
            if (span.TotalDays < 2 && span.TotalDays >= 1 && (DateTime.Now.Day - dt.Day) == 1)
            {
                return "昨天 " + dt.ToString("HH:mm") + "";
            }
            if (span.TotalDays < 3 && (DateTime.Now.Day - dt.Day) == 2)
            {
                return "前天 " + dt.ToString("HH:mm") + "";
            }
            //if (span.TotalDays <= 30 && dt.Year == DateTime.Now.Year)
            //{
            //    return dt.ToString("MM月dd日");
            //}

            return dt.ToString("yyyy-MM-dd HH:mm") + "";
        }


        /// <summary>
        /// 获取date所在周的星期一和星期日
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Tuple<DateTime, DateTime> GetWeekRange(DateTime? date)
        {
            var dt = date == null ? DateTime.Now : date.Value;

            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                return new Tuple<DateTime, DateTime>(dt.AddDays(-6), dt);
            }
            else
            {
                return new Tuple<DateTime, DateTime>(dt.AddDays(1 - (int)dt.DayOfWeek), dt.AddDays(7 - (int)dt.DayOfWeek));
            }
        }
    }
}
