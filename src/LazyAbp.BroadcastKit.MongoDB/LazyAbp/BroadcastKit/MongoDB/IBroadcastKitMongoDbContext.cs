using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LazyAbp.BroadcastKit.MongoDB
{
    [ConnectionStringName(BroadcastKitDbProperties.ConnectionStringName)]
    public interface IBroadcastKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
