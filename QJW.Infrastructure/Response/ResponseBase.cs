using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QJW.Infrastructure.Response
{
    public class ResponseBase<T> : IResponse
    {
        public T Item { get; set; }
    }
}
