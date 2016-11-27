using System;
using System.Collections.Generic;
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

            string url = "http://m.qpic.cn/psu?/5102ca6c-5cfd-4faa-84f1-793b63927224/3P2qzirX0pJNhPr*Jg2skWULdgropDl*p1BudCg6uME%21/b/YTzDCRyhPwAAYnrbfRgBSAAA&ek=1&kp=1&pt=0&su=0191137777&sce=0-12-12&rf=2-9&wx_lazy=1";
            string filename = "c:\\1.gif";

            DownloadFile(url, filename, null);
            msg = "ok";

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

                if (contentType=="image/gif")
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
    }
}
