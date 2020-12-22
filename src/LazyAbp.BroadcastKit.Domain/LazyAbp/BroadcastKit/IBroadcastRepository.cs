using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace LazyAbp.BroadcastKit
{
    public interface IBroadcastRepository : IRepository<Broadcast, Guid>
    {
        Task<long> GetCountAsync(
            bool? isActive = null,
            DateTime? startAfter = null,
            DateTime? startBefore = null,
            DateTime? expireAfter = null,
            DateTime? expireBefore = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Broadcast>> GetListAsync(
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
        );
    }
}