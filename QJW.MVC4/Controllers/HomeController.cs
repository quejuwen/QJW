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


            string url = Request.Url.AbsoluteUri;

            if (Request.QueryString["invitid"]==null)
            {
                url = QJW.URLHelper.AddParam(url, "invitid", "18");
                Easp.RR(url);
            }
            if (Easp.Get("invitid")!="18")
            {
                url = QJW.URLHelper.UpdateParam(url, "invitid", "18" );
                Easp.RR(url);
               
            }

            msg = url;

            //msg = Easp.GetQRCode("http://www.xiangguhr.com",2);

            //msg = Easp.GetReferer();
            //msg = Easp.GetUrl();

            ViewBag.msg = msg;
            return View();
        }

    }
}
