using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lazy.Abp.BroadcastKit;

namespace Lazy.Abp.BroadcastKit.EntityFrameworkCore
{
    [ConnectionStringName(BroadcastKitDbProperties.ConnectionStringName)]
    public interface IBroadcastKitDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Broadcast> Broadcasts { get; set; }
    }
}
