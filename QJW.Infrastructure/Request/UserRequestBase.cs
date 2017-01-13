using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Infrastructure.Request
{
    public abstract class UserRequestBase : IRequest
    {
        public int ApiUserID { get; set; }
        public string ApiUserName { get; set; }
        // ......可以添加其他要专递的登录用户相关的信息

        public abstract ResultObject Validate();
    }
}
