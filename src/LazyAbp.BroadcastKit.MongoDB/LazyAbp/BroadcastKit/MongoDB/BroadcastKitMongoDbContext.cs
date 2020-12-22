using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LazyAbp.BroadcastKit.MongoDB
{
    [ConnectionStringName(BroadcastKitDbProperties.ConnectionStringName)]
    public class BroadcastKitMongoDbContext : AbpMongoDbContext, IBroadcastKitMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBroadcastKit();
        }
    }
}