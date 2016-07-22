using CYQ.Data;
using CYQ.Data.Table;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;

namespace QJW
{
    public static class Easp
    {

        #region 通用工具方法
        /// <summary>
        /// 生成二维码，返回二维码的相对路径
        /// </summary>
        /// <param name="url">二维码url</param>
        /// <returns>二维码图片相对路径</returns>
        public static string GetQRCode(string url)
        {
            return GetQRCode(url, 3);

        }
        /// <summary>
        /// 生成二维码，返回二维码的相对路径
        /// </summary>
        /// <param name="url">二维码url</param>
        /// <param name="version">二维码版本号</param>
        /// <returns>二维码图片相对路径</returns>
        public static string GetQRCode(string url, int version)
        {
            return GetQRCode(url, version, string.Empty);
        }
        /// <summary>
        /// 生成二维码，返回二维码的相对路径
        /// </summary>
        /// <param name="url">二维码url</param>
        /// <param name="version">二维码版本号</param>
        /// <param name="path">相对路径：/upload/20160708/123456789.jpg</param>
        /// <returns>二维码图片相对路径</returns>
        public static string GetQRCode(string url, int version, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "/upload/" + DateTime.Now.ToString("yyyyMMdd") + "/" + MD5(url, 16) + ".JPG";
            }
            string physicpath = System.Web.HttpContext.Current.Server.MapPath(path);
            string filePath = Path.GetDirectoryName(physicpath);
            Directory.CreateDirectory(filePath);

            QrCodeHelper.GCode(url, version).Save(physicpath, System.Drawing.Imaging.ImageFormat.Jpeg);
            return path;
        }

        #endregion


        #region WEB

        /// <summary>
        /// 获取当前网页地址
        /// </summary>
        /// <returns></returns>
        public static string GetUrl()
        {
            return HttpContext.Current.Request.Url.AbsoluteUri;
        }


        /// <summary>
        /// 来路地址
        /// </summary>
        /// <returns></returns>
        public static string GetReferer()
        {
            return HttpContext.Current.Request.ServerVariables["HTTP_REFERER"];
        }


        /// <summary>
        /// 提示并返回
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void Alert(string message)
        {
            WE(string.Format(@"<script language=javascript>alert('{0}');history.go(-1);</script>", message));
        }

        /// <summary>
        /// 提示并跳转
        /// </summary>
        /// <param name="message"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static void AlertUrl(string message, string url)
        {
            WE(string.Format(@"<script language=javascript>alert('{0}');location.href='{1}';</script>", message, url));
        }

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="str"></param>
        public static void W(string str)
        {

            HttpContext.Current.Response.Write(str);
        }

        /// <summary>
        /// 输出并换行
        /// </summary>
        /// <param name="str"></param>
        public static void WN(string str)
        {
            HttpContext.Current.Response.Write(str + "<br />");
        }

        /// <summary>
        /// 输出并结束
        /// </summary>
        /// <param name="str"></param>
        public static void WE(string str)
        {
            HttpContext.Current.Response.Write(str);
            HttpContext.Current.Response.End();
        }
        /// <summary>
        /// 跳转url
        /// </summary>
        /// <param name="str"></param>
        public static void RR(string str)
        {
            HttpContext.Current.Response.Redirect(str);
            HttpContext.Current.Response.End();

        }



        /// <summary>
        /// 获得缓存名为key的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Cache(string key)
        {
            return CYQ.Data.Cache.CacheManage.Instance.Get(key);
        }

        /// <summary>
        /// 设置缓存值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void CacheSet(string key, object value)
        {
            CYQ.Data.Cache.CacheManage.Instance.Set(key, value);
        }



        /// <summary>
        /// 安全获取QueryString值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Get(string name)
        {
            return Get(name, string.Empty);
        }

        /// <summary>
        /// 安全获取QueryString值，如空则返回默认值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public static string Get(string name, string defaultvalue)
        {
            return HttpContext.Current.Request.QueryString[name] == null ? defaultvalue : HttpContext.Current.Request.QueryString[name];
        }


        /// <summary>
        /// 安全获取ID值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetInt(string name)
        {
            return GetInt(name, 0);
        }

        /// <summary>
        /// 安全获取ID值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public static int GetInt(string name, int defaultvalue)
        {
            int result = defaultvalue;
            if (!int.TryParse(Get(name), out result))
            {
                return defaultvalue;
            }
            return result;
        }

        /// <summary>
        /// 安全获取Form值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Post(string name)
        {
            return Post(name, string.Empty);
        }

        /// <summary>
        /// 安全获取Form值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public static string Post(string name, string defaultvalue)
        {
            return HttpContext.Current.Request.Form[name] == null ? defaultvalue : HttpContext.Current.Request.Form[name];
        }


        /// <summary>
        /// 安全获取Form中ID值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int PostInt(string name)
        {
            return PostInt(name, 0);
        }

        /// <summary>
        /// 安全获取Form中ID值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public static int PostInt(string name, int defaultvalue)
        {
            int result = defaultvalue;
            if (!int.TryParse(Post(name), out result))
            {
                return defaultvalue;
            }
            return result;
        }





        #endregion


        #region 数据库操作

        /// <summary>
        /// 运行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static int Exec(string sql, string conn = "Conn")
        {
            using (MProc proc = new MProc(sql, conn))
            {

                return proc.ExeNonQuery();
            }
        }


        /// <summary>
        /// 运行sql并返回首行首列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static T ExeScalar<T>(string sql, string conn = "Conn")
        {
            using (MProc proc = new MProc(sql, conn))
            {
                return proc.ExeScalar<T>();
            }
        }

        /// <summary>
        /// 返回MDataTable表数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static MDataTable ExeMDataTable(string sql, string conn = "Conn")
        {
            using (MProc proc = new MProc(sql, conn))
            {
                return proc.ExeMDataTable();
            }

        }

        /// <summary>
        /// 创建空行，返回实体，默认值均已赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T Create<T>(object key, object value)
        {
            return Create<T>(key, value, InsertOp.ID);
        }

        /// <summary>
        /// 创建空行，返回实体，默认值均已赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        public static T Create<T>(object key, object value, InsertOp op)
        {
            T result = default(T);
            bool flag = false;
            MDataRow mDataRow = null;
            using (MAction mAction = GetMAction<T>())
            {
                mAction.Set(key, value);
                flag = mAction.Insert(op);
                if (flag && op != InsertOp.None)
                {
                    mDataRow = mAction.Data;
                }
            }

            if (mDataRow != null)
            {
                return mDataRow.ToEntity<T>();
            }
            return result;
        }

        /// <summary>
        /// 获取实体对应的MAction对像
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static MAction GetMAction<T>()
        {
            string conn = string.Empty;
            MAction action = new MAction(GetTableName<T>(out conn), conn);
            action.SetAopOff();
            return action;
        }

        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string GetTableName<T>(out string conn)
        {
            conn = string.Empty;
            Type t = typeof(T);

            string[] items = t.FullName.Split('.');
            if (items.Length > 1)
            {
                conn = items[items.Length - 2] + "Conn";
                items = null;
            }
            string tName = t.Name;
            t = null;
            return tName;
        }



        #endregion


        #region 字符串加密
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="plaintext"></param>
        /// <returns></returns>
        public static string EncryptString(string plaintext)
        {
            return EncryptString(plaintext, "QQ" + DateTime.Now.ToString("MMddHH"));
        }
        /// <summary>   
        /// 利用DES加密算法加密字符串（可解密）   
        /// </summary>   
        /// <param name="plaintext">被加密的字符串</param>   
        /// <param name="key">密钥（只支持8个字节的密钥）</param>   
        /// <returns>加密后的字符串</returns>   
        public static string EncryptString(string plaintext, string key)
        {
            //访问数据加密标准(DES)算法的加密服务提供程序 (CSP) 版本的包装对象   
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = ASCIIEncoding.ASCII.GetBytes(key);　//建立加密对象的密钥和偏移量   
            des.IV = ASCIIEncoding.ASCII.GetBytes(key);　 //原文使用ASCIIEncoding.ASCII方法的GetBytes方法   

            byte[] inputByteArray = Encoding.Default.GetBytes(plaintext);//把字符串放到byte数组中   

            MemoryStream ms = new MemoryStream();//创建其支持存储区为内存的流　   
            //定义将数据流链接到加密转换的流   
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            //上面已经完成了把加密后的结果放到内存中去   
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }


        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="plaintext"></param>
        /// <returns></returns>
        public static string DecryptString(string plaintext)
        {
            return DecryptString(plaintext, "QQ" + DateTime.Now.ToString("MMddHH"));
        }
        /// <summary>   
        /// 利用DES解密算法解密密文（可解密）   
        /// </summary>   
        /// <param name="ciphertext">被解密的字符串</param>   
        /// <param name="key">密钥（只支持8个字节的密钥，同前面的加密密钥相同）</param>   
        /// <returns>返回被解密的字符串</returns>   
        public static string DecryptString(string ciphertext, string key)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                byte[] inputByteArray = new byte[ciphertext.Length / 2];
                for (int x = 0; x < ciphertext.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(ciphertext.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }

                des.Key = ASCIIEncoding.ASCII.GetBytes(key);　//建立加密对象的密钥和偏移量，此值重要，不能修改   
                des.IV = ASCIIEncoding.ASCII.GetBytes(key);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);

                cs.FlushFinalBlock();

                //建立StringBuild对象，createDecrypt使用的是流对象，必须把解密后的文本变成流对象   
                StringBuilder ret = new StringBuilder();

                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception)
            {
                return "error";
            }
        }

        /// <summary>
        /// 返回MD5字符（32位大写字母），取16位则 Substring(8,16)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }

        /// <summary>
        /// 返回MD5字符（16位大写字母）
        /// </summary>
        /// <param name="str"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string MD5(string str, int count)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, count);
        }

        //SHA1
        static public string SHA1(string str_sha1_in)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes_sha1_in = UTF8Encoding.Default.GetBytes(str_sha1_in);
            byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            string str_sha1_out = BitConverter.ToString(bytes_sha1_out);
            str_sha1_out = str_sha1_out.Replace("-", "");
            return str_sha1_out;
        }

        #endregion


    }
}
