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

            //msg = Easp.GetQRCode("http://www.xiangguhr.com",2);

            msg = Easp.GetReferer();


            ViewBag.msg = msg;
            return View();
        }

    }
}
