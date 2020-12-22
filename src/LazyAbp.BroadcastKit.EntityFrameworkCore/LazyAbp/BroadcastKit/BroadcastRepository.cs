using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using LazyAbp.BroadcastKit.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LazyAbp.BroadcastKit
{
    public class BroadcastRepository : EfCoreRepository<IBroadcastKitDbContext, Broadcast, Guid>, IBroadcastRepository
    {
        public BroadcastRepository(IDbContextProvider<IBroadcastKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<long> GetCountAsync(
                bool? isActive = null,
                DateTime? startAfter = null,
                DateTime? startBefore = null,
                DateTime? expireAfter = null,
                DateTime? expireBefore = null,
                string filter = null,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(isActive, startAfter, startBefore, expireAfter, expireBefore, filter);

            var totalCount = await query.LongCountAsync(GetCancellationToken(cancellationToken));

            return totalCount;
        }

        public async Task<List<Broadcast>> GetListAsync(
                string sorting = null,
                int maxResultCount = 10,
                int skipCount = 0,
                bool? isActive = null,
                DateTime? startAfter = null,
                DateTime? startBefore = null,
                DateTime? expireAfter = null,
                DateTime? expireBefore = null,
                string filter = null,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(isActive, startAfter, startBefore, expireAfter, expireBefore, filter);

            var broadcasts = await query.OrderBy(sorting ?? "creationTime desc")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));

            return broadcasts;
        }

        protected virtual IQueryable<Broadcast> GetListQuery(
                bool? isActive = null,
                DateTime? startAfter = null,
                DateTime? startBefore = null,
                DateTime? expireAfter = null,
                DateTime? expireBefore = null,
                string filter = null
            )
        {
            return DbSet.AsNoTracking()
                .WhereIf(isActive.HasValue, e => false || e.IsActive == isActive)
                .WhereIf(startAfter.HasValue, e => false || e.StartTime >= startAfter.Value)
                .WhereIf(startBefore.HasValue, e => false || e.StartTime <= startBefore.Value)
                .WhereIf(expireAfter.HasValue, e => false || e.ExpireTime >= expireAfter.Value)
                .WhereIf(expireBefore.HasValue, e => false || e.ExpireTime <= expireBefore.Value)
                .WhereIf(!string.IsNullOrEmpty(filter), 
                    e => false 
                    || e.Title.Contains(filter) 
                    || e.FullDescription.Contains(filter)
                );
        }
    }
}