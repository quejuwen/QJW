using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using QJW.Infrastructure;
using QJW.Infrastructure.Json;

namespace QJW.WebBase
{
    /// <summary>
    /// api返回结果，控制jsonp、跨域、小驼峰命名和时间格式问题
    /// </summary>
    public class ApiResult : ActionResult
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        public ResultObject ResultData { get; set; }

        /// <summary>
        /// 返回数据编码，默认utf8
        /// </summary>
        public Encoding ContentEncoding { get; set; }

        /// <summary>
        /// 是否接受Get请求，默认允许
        /// </summary>
        public JsonRequestBehavior JsonRequestBehavior { get; set; }

        /// <summary>
        /// 是否允许跨域请求
        /// </summary>
        public bool AllowCrossDomain { get; set; }

        /// <summary>
        /// jsonp回调参数名
        /// </summary>
        public string JsonpCallbackName = "callback";

        public ApiResult() : this(null)
        {
        }

        public ApiResult(ResultObject resultData)
        {
            this.ResultData = resultData;
            ContentEncoding = Encoding.UTF8;
            JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            AllowCrossDomain = true;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            var request = context.HttpContext.Request;

            response.ContentEncoding = ContentEncoding;
            response.ContentType = "text/plain";
            if (ResultData != null)
            {
                string buffer;
                if ((JsonRequestBehavior == JsonRequestBehavior.DenyGet) && string.Equals(context.HttpContext.Request.HttpMethod, "GET"))
                {
                    buffer = "该接口不允许Get请求";
                }
                else
                {

                    var jsonpCallback = request[JsonpCallbackName];
                    if (string.IsNullOrWhiteSpace(jsonpCallback))
                    {
                        //如果可以跨域，写入响应头
                        if (AllowCrossDomain)
                        {
                            WriteAllowAccessOrigin(context);
                        }
                        response.ContentType = "application/json";
                        buffer = JsonConvert.SerializeObject(ResultData, JsonSetting.Settings);
                    }
                    else
                    {
                        //jsonp
                        if (AllowCrossDomain) //这个判断可能非必须
                        {
                            response.ContentType = "text/javascript";
                            buffer = string.Format("{0}({1});", jsonpCallback, JsonConvert.SerializeObject(ResultData, JsonSetting.Settings));
                        }
                        else
                        {
                            buffer = "该接口不允许跨域请求";
                        }
                    }
                }
                try
                {
                    response.Write(buffer);
                }
                catch (Exception exp)
                {
                    response.Write(exp.Message);
                }
            }
            else
            {
                response.Write("ApiResult.Data为null");
            }
            response.End();
        }

        /// <summary>
        /// 写入跨域请求头
        /// </summary>
        /// <param name="context"></param>
        private void WriteAllowAccessOrigin(ControllerContext context)
        {
            var origin = context.HttpContext.Request.Headers["Origin"];
            if (true) //可以维护一个允许跨域的域名集合，类判断是否可以跨域
            {
                context.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", origin ?? "*");
            }
        }

    }
}
