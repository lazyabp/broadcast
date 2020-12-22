using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LazyAbp.BroadcastKit
{
    public static class BroadcastEfCoreQueryableExtensions
    {
        public static IQueryable<Broadcast> IncludeDetails(this IQueryable<Broadcast> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}