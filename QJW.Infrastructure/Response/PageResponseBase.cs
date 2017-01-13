using Loogn.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QJW.Infrastructure.Request;

namespace QJW.Infrastructure.Response
{
    public class PageResponseBase<T>: ListResponseBase<T>
    {
        public PageResponseBase() { }
        public PageResponseBase(PageRequestBase request)
        {
            PageIndex = request.PageIndex;
            PageSize = request.PageSize;
        }
        public PageResponseBase(OrmLitePageInfo pageInfo)
        {
            PageIndex = pageInfo.PageIndex;
            PageSize = pageInfo.PageSize;
            TotalCount = pageInfo.TotalCount;
        }
        /// <summary>
        /// 页码数
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public long TotalCount { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public long PageCount { get; set; }
    }
}
