using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Infrastructure.Request
{
    public interface IRequest
    {
        ResultObject Validate();
    }
}
