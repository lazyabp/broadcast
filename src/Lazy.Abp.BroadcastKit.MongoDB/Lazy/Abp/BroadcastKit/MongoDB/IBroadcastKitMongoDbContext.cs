using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.BroadcastKit.MongoDB
{
    [ConnectionStringName(BroadcastKitDbProperties.ConnectionStringName)]
    public interface IBroadcastKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
