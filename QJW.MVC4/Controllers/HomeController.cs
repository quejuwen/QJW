﻿using CYQ.Data;
using CYQ.Data.Orm;
using DB.chinacfoclub;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QJW.MVC4.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            string msg = string.Empty;

            //string url = "http://m.qpic.cn/psu?/5102ca6c-5cfd-4faa-84f1-793b63927224/3P2qzirX0pJNhPr*Jg2skWULdgropDl*p1BudCg6uME%21/b/YTzDCRyhPwAAYnrbfRgBSAAA&ek=1&kp=1&pt=0&su=0191137777&sce=0-12-12&rf=2-9&wx_lazy=1";
            //string filename = "c:\\1.gif";

            //DownloadFile(url, filename, null);
            //msg = "ok";

            //string url = Request.Url.AbsoluteUri;

            //if (Request.QueryString["invitid"]==null)
            //{
            //    url = QJW.URLHelper.AddParam(url, "invitid", "18");
            //    Easp.RR(url);
            //}
            //if (Easp.Get("invitid")!="18")
            //{
            //    url = QJW.URLHelper.UpdateParam(url, "invitid", "18" );
            //    Easp.RR(url);

            //}

            //msg = url;

            ////msg = Easp.GetQRCode("http://www.xiangguhr.com",2);

            ////msg = Easp.GetReferer();
            ////msg = Easp.GetUrl();





            ViewBag.msg = msg;
            return View();
        }

        public ActionResult ArticleDel(int id)
        {
            //var a = DBFast.Find<KS_Article>(id);
            //a.DelTF = 1;
            //DBFast.Update<KS_Article>(a);

            //using (MProc proc = new MProc("update ks_article set deltf=1 where id=" + id))
            //{
            //    proc.ExeNonQuery();
            //}

            //CYQ.Data.Cache.CacheManage.Instance.Clear();

            QJW.Easp.Exec("update ks_article set deltf=1 where id=" + id);

            //QJW.Easp.Exec("update ks_article set deltf=1 where id=" + id,"Conn");
            //using (MAction action =new MAction("KS_Article"))
            //{
            //    if (action.Fill(id))
            //    {
            //        action.Set("deltf", "1");
            //        action.Update();
            //    }
            //}

            return Redirect("/");
        }

        public static int Exec(string sql, string conn = "Conn")
        {
            using (MProc proc = new MProc(sql, conn))
            {

                return proc.ExeNonQuery();
            }
        }



        public ActionResult clear()
        {
            CYQ.Data.Cache.CacheManage.Instance.Clear();
            return Redirect("/");
        }

        /// <summary>        
        /// 下载文件        
        /// </summary>        
        /// <param name="URL">下载文件地址</param>       
        /// <param name="Filename">下载后的存放地址</param>        
        /// <param name="Prog">用于显示的进度条</param>        
        ///      
        public void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog)
        {

            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                string contentType = myrp.ContentType;

                if (contentType == "image/gif")
                {

                }

                long totalBytes = myrp.ContentLength;

                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }

                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;

                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public FileContentResult CreateValidate()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(5);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);

            return File(bytes, "image/JPEG");
        }

        public FileContentResult GetQr(string url,int version=3)
        {
            var img = QJW.QrCodeHelper.GCode(url, version);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return File(ms.GetBuffer(), "image/JPEG");
        }


        public FileContentResult CreateImageVerify()
        {
            Common.VerifyCodeHelper verify = new Common.VerifyCodeHelper();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //将图像保存到指定的流
            verify.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return File(ms.GetBuffer(), "image/JPEG");
        }


        #region 生成校验码图片
        public FileContentResult CreateImageCode()
        {
            string code = CreateVerifyCode(4);
            Session["VerifyCode"] = code.ToUpper();
            int fSize = FontSize;
            int fWidth = fSize + Padding;
            int imageWidth = (int)(code.Length * fWidth) + 4 + Padding * 2;
            int imageHeight = fSize * 2 + Padding;

            System.Drawing.Bitmap image = new System.Drawing.Bitmap(imageWidth, imageHeight);
            Graphics g = Graphics.FromImage(image);
            g.Clear(BackgroundColor);
            Random rand = new Random();

            //给背景添加随机生成的燥点
            if (this.Chaos)
            {
                Pen pen = new Pen(ChaosColor, 0);
                int c = Length * 10;

                for (int i = 0; i < c; i++)
                {
                    int x = rand.Next(image.Width);
                    int y = rand.Next(image.Height);

                    g.DrawRectangle(pen, x, y, 1, 1);
                }
            }

            int left = 0, top = 0, top1 = 1, top2 = 1;

            int n1 = (imageHeight - FontSize - Padding * 2);
            int n2 = n1 / 4;
            top1 = n2;
            top2 = n2 * 2;

            Font f;
            Brush b;
            int cindex, findex;

            //随机字体和颜色的验证码字符
            for (int i = 0; i < code.Length; i++)
            {
                cindex = rand.Next(Colors.Length - 1);
                findex = rand.Next(Fonts.Length - 1);

                f = new System.Drawing.Font(Fonts[findex], fSize, System.Drawing.FontStyle.Bold);
                b = new System.Drawing.SolidBrush(Colors[cindex]);

                if (i % 2 == 1)
                {
                    top = top2;
                }
                else
                {
                    top = top1;
                }

                left = i * fWidth;

                g.DrawString(code.Substring(i, 1), f, b, left, top);
            }

            //画一个边框 边框颜色为Color.Gainsboro
            g.DrawRectangle(new Pen(Color.Gainsboro, 0), 0, 0, image.Width - 1, image.Height - 1);
            g.Dispose();

            //产生波形
            image = TwistImage(image, true, 0, 4);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //将图像保存到指定的流
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return File(ms.GetBuffer(), "image/JPEG");


        }
        #endregion









        #region 属性

        #region 验证码长度
        int length = 4;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        #endregion

        #region 验证码字体大小(为了显示扭曲效果，默认40像素，可以自行修改)
        int fontSize = 25;
        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        #endregion

        #region 边框补(默认1像素)
        int padding = 2;
        public int Padding
        {
            get { return padding; }
            set { padding = value; }
        }
        #endregion

        #region 是否输出燥点(默认不输出)
        bool chaos = false;
        public bool Chaos
        {
            get { return chaos; }
            set { chaos = value; }
        }
        #endregion

        #region 输出燥点的颜色(默认灰色)
        Color chaosColor = Color.LightGray;
        public Color ChaosColor
        {
            get { return chaosColor; }
            set { chaosColor = value; }
        }
        #endregion

        #region 自定义背景色(默认白色)
        Color backgroundColor = Color.White;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
        #endregion

        #region 自定义随机颜色数组
        Color[] colors = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
        public Color[] Colors
        {
            get { return colors; }
            set { colors = value; }
        }
        #endregion

        #region 自定义字体数组
        string[] fonts = { "Arial", "Georgia" };
        public string[] Fonts
        {
            get { return fonts; }
            set { fonts = value; }
        }
        #endregion

        #region 自定义随机码字符串序列(使用逗号分隔)
        string codeSerial = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        public string CodeSerial
        {
            get { return codeSerial; }
            set { codeSerial = value; }
        }
        #endregion
        #endregion

        #region 产生波形滤镜效果

        private const double PI = 3.1415926535897932384626433832795;
        private const double PI2 = 6.283185307179586476925286766559;

        /// <summary>
        /// 正弦曲线Wave扭曲图片（Edit By 51aspx.com）
        /// </summary>
        /// <param name="srcBmp">图片路径</param>
        /// <param name="bXDir">如果扭曲则选择为True</param>
        /// <param name="nMultValue">波形的幅度倍数，越大扭曲的程度越高，一般为3</param>
        /// <param name="dPhase">波形的起始相位，取值区间[0-2*PI)</param>
        /// <returns></returns>
        public System.Drawing.Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)
        {
            System.Drawing.Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);

            // 将位图背景填充为白色
            System.Drawing.Graphics graph = System.Drawing.Graphics.FromImage(destBmp);
            graph.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, destBmp.Width, destBmp.Height);
            graph.Dispose();

            double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;

            for (int i = 0; i < destBmp.Width; i++)
            {
                for (int j = 0; j < destBmp.Height; j++)
                {
                    double dx = 0;
                    dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);

                    // 取得当前点的颜色
                    int nOldX = 0, nOldY = 0;
                    nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                    nOldY = bXDir ? j : j + (int)(dy * dMultValue);

                    System.Drawing.Color color = srcBmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < destBmp.Width
                     && nOldY >= 0 && nOldY < destBmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }

            return destBmp;
        }



        #endregion

        #region 生成随机字符码
        public string CreateVerifyCode(int codeLen)
        {
            if (codeLen == 0)
            {
                codeLen = Length;
            }

            string[] arr = CodeSerial.Split(',');

            string code = "";

            int randValue = -1;

            Random rand = new Random(unchecked((int)DateTime.Now.Ticks));

            for (int i = 0; i < codeLen; i++)
            {
                randValue = rand.Next(0, arr.Length - 1);

                code += arr[randValue];
            }

            return code;
        }
        public string CreateVerifyCode()
        {
            return CreateVerifyCode(0);
        }
        #endregion






















    }
}
