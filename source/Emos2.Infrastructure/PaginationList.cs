using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure
{
    public class PaginationList<T> : List<T>
    {

        public PaginationList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            this.AddRange(source);

            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.TotalPageCount = (int)Math.Ceiling(totalCount / (double)pageSize);
        }


        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPageCount { get; private set; }

    }

    public static class PaginationQueryableExtensions
    {
        public static PaginationList<T> ToPaginatedList<T>(this IQueryable<T> query, int pageIndex, int pageSize)
        {
            int totalCount = query.Count();
            IQueryable<T> collection = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return new PaginationList<T>(collection, pageIndex, pageSize, totalCount);
        }
    }
}
