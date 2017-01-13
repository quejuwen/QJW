using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Infrastructure
{
    /// <summary>
    /// api说明信息
    /// </summary>
    public class ApiInfoAttribute : Attribute
    {
        public ApiInfoAttribute(string description, Type responseType)
        {
            var resultType = typeof(ResultObject);

            if (responseType != resultType && !responseType.IsSubclassOf(resultType))
            {
                throw new ArgumentException("responseType 必须是ResultObject或其子类");
            }
            Description = description;
            ResponseType = responseType;
        }

        public ApiInfoAttribute(string description) : this(description, typeof(ResultObject))
        {
        }

        /// <summary>
        /// 接口描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 返回值类型
        /// </summary>
        public Type ResponseType { get; set; }


    }
}
