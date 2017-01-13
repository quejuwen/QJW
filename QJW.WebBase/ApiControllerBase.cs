using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using QJW.Infrastructure;
using QJW.Infrastructure.Request;

namespace QJW.WebBase
{
    /// <summary>
    /// API控制器基类
    /// </summary>
    public class ApiControllerBase : AsyncController
    {
        public ApiResult Api<TRequest>(TRequest request, Func<TRequest, ResultObject> handle)
        {
            try
            {
                var requestBase = request as IRequest;
                if (requestBase != null)
                {
                    //处理需要登录用户的请求
                    var userRequest = request as UserRequestBase;
                    if (userRequest != null)
                    {
                        var loginUser = LoginUser.GetUser();
                        if (loginUser != null)
                        {
                            userRequest.ApiUserID = loginUser.UserID;
                            userRequest.ApiUserName = loginUser.UserName;
                        }
                    }
                    var validResult = requestBase.Validate();
                    if (validResult != null)
                    {
                        return new ApiResult(validResult);
                    }
                }
                //处理请求
                var result = handle(request);

                return new ApiResult(result);
            }
            catch (Exception exp)
            {
                //异常日志：

                return new ApiResult { ResultData = new ResultObject { Code = 1, Msg = "系统异常：" + exp.Message } };
                throw exp;
            }
        }

        public ApiResult Api(Func<ResultObject> handle)
        {
            try
            {
                //处理请求
                var result = handle();
                return new ApiResult(result);
            }
            catch (Exception exp)
            {
                //异常日志：
                return new ApiResult { ResultData = new ResultObject { Code = 1, Msg = "系统异常：" + exp.Message } };
                throw exp;
            }
        }

        /// <summary>
        /// 异步api
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <param name="request"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public Task<ApiResult> ApiAsync<TRequest, TResponse>(TRequest request, Func<TRequest, Task<TResponse>> handle) where TResponse : ResultObject
        {
            return handle(request).ContinueWith(x =>
            {
                return Api(() => x.Result);
            });
        }
    }
}
