using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Infrastructure.Request
{
    public abstract class PageRequestBase : UserRequestBase
    {
        [JsonIgnore]
        public int PageIndex { get; set; }

        [JsonIgnore]
        public int PageSize { get; set; }
    }
}
