using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QJW.Infrastructure.Response;

namespace QJW.Infrastructure
{
    public class ResultObject
    {
        /// <summary>
        /// 等于0表示成功
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// code不为0时，返回错误消息
        /// </summary>
        public string Msg { get; set; }
    }


    public class ResultObject<TResponse> : ResultObject where TResponse : IResponse
    {
        public ResultObject()
        {
        }
        public ResultObject(TResponse data)
        {
            Data = data;
        }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public TResponse Data { get; set; }

    }

}
