using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using QJW.Infrastructure;

namespace QJW.WebBase
{
    public class AuthFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 匿名可访问
        /// </summary>
        public bool AllowAnonymous { get; set; }

        /// <summary>
        /// 登录用户就可以访问
        /// </summary>
        public bool OnlyLogin { get; set; }
        
        /// <summary>
        /// 使用的资源权限名，比如多个接口可以使用同一个资源的权限，默认是/ControllerName/ActionName
        /// </summary>
        public string PowerName { get; set; }


        public sealed override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //跨域时，客户端会用OPTIONS请求来探测服务器
            if (filterContext.HttpContext.Request.HttpMethod == "OPTIONS")
            {
                var origin = filterContext.HttpContext.Request.Headers["Origin"];
                if (true) //可以维护一个允许跨域的域名集合，类判断是否可以跨域
                {
                    filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", origin ?? "*");
                }
                filterContext.Result = new EmptyResult();
                return;
            }

            if (AllowAnonymous) return;
            var user = LoginUser.GetUser();
            if (user == null)
            {
                filterContext.Result = new ApiResult
                {
                    ResultData = new ResultObject { Code = -1, Msg = "未登录" },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
                return;
            }
            if (OnlyLogin) return;


            if (user.Role == "admin")
            {
                return;
            }
            var url = PowerName;
            if (string.IsNullOrEmpty(url))
            {
                url = "/" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "/" + filterContext.ActionDescriptor.ActionName;
            }

            var hasPower = true; //可以根据 user和url等信息判断是否有权限
            if (!hasPower)
            {
                filterContext.Result = new ApiResult
                {
                    ResultData = new ResultObject { Code = -2, Msg = "无权限" },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }
        
    }
}
