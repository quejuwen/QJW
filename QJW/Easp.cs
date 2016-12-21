using CYQ.Data;
using CYQ.Data.Table;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!File.Exists(physicpath))
            {
                string filePath = Path.GetDirectoryName(physicpath);
                Directory.CreateDirectory(filePath);

                QrCodeHelper.GCode(url, version).Save(physicpath, System.Drawing.Imaging.ImageFormat.Jpeg);
     
            }

            return path;
        }

        #endregion


        #region WEB

        public static bool IsMobile()
        {
            HttpContext current = HttpContext.Current;
            string text = current.Request.ServerVariables["HTTP_USER_AGENT"];
            Regex regex = new Regex("android|avantgo|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\\\\/|plucker|pocket|psp|symbian|treo|up\\\\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex regex2 = new Regex("1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\\\\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\\\\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\\\\-(n|u)|c55\\\\/|capi|ccwa|cdm\\\\-|cell|chtm|cldc|cmd\\\\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\\\\-s|devi|dica|dmob|do(c|p)o|ds(12|\\\\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\\\\-|_)|g1 u|g560|gene|gf\\\\-5|g\\\\-mo|go(\\\\.w|od)|gr(ad|un)|haie|hcit|hd\\\\-(m|p|t)|hei\\\\-|hi(pt|ta)|hp( i|ip)|hs\\\\-c|ht(c(\\\\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\\\\-(20|go|ma)|i230|iac( |\\\\-|\\\\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\\\\/)|klon|kpt |kwc\\\\-|kyo(c|k)|le(no|xi)|lg( g|\\\\/(k|l|u)|50|54|e\\\\-|e\\\\/|\\\\-[a-w])|libw|lynx|m1\\\\-w|m3ga|m50\\\\/|ma(te|ui|xo)|mc(01|21|ca)|m\\\\-cr|me(di|rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\\\\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\\\\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\\\\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\\\\-2|po(ck|rt|se)|prox|psio|pt\\\\-g|qa\\\\-a|qc(07|12|21|32|60|\\\\-[2-7]|i\\\\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\\\\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\\\\-|oo|p\\\\-)|sdk\\\\/|se(c(\\\\-|0|1)|47|mc|nd|ri)|sgh\\\\-|shar|sie(\\\\-|m)|sk\\\\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\\\\-|v\\\\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\\\\-|tdg\\\\-|tel(i|m)|tim\\\\-|t\\\\-mo|to(pl|sh)|ts(70|m\\\\-|m3|m5)|tx\\\\-9|up(\\\\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\\\\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\\\\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|xda(\\\\-|2|g)|yas\\\\-|your|zeto|zte\\\\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return regex.IsMatch(text) || regex2.IsMatch(text.Substring(0, 4));
        }

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
            WE(string.Format(@"<script language=javascript>alert('{0}');history.go(-1);</script>", message.Replace("\n","").Replace("\r","")));
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
            using (MProc proc = new MProc(sql))
            {
                return proc.ExeMDataTable();
            }

        }


        /// <summary>
        /// 返回MDataTable表数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static MDataTable ExeMDataTable(string table, string where, string conn = "Conn")
        {
            MDataTable mtable = null;
            using (MAction action = new MAction(table, conn))
            {
                mtable = action.Select(where);
            }
            return mtable;

        }


        /// <summary>
        /// 返回MDataTable表数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static MDataTable ExeMDataTable(string table,int top,string where,string conn="Conn")
        {
            MDataTable mtable = null;
            using (MAction action =new MAction(table,conn))
            {
                mtable = action.Select(top, where);
            }
            return mtable;

        }
        /// <summary>
        /// 返回MDataTable表数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <param name="where"></param>
        /// <param name="total"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static MDataTable ExeMDataTable(string table,int page, int pagesize, string where, out int total, string conn = "Conn")
        {
            MDataTable mtable = null;
            using (MAction action =new MAction(table,conn))
            {
                mtable = action.Select(page, pagesize, where, out total);
            }
            return mtable;
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
            //action.SetAopOff();
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
        public static string SHA1(string str_sha1_in)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes_sha1_in = UTF8Encoding.Default.GetBytes(str_sha1_in);
            byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            string str_sha1_out = BitConverter.ToString(bytes_sha1_out);
            str_sha1_out = str_sha1_out.Replace("-", "");
            return str_sha1_out;
        }

        /// <summary>
        /// 获得唯一ID
        /// </summary>
        /// <returns></returns>
        public static string UniqueID()
        {
            string password = string.Format("{0}{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), Guid.NewGuid().ToString().Split(new char[] { '-' })[4]);
            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower();
        }





        #endregion


    }
}
