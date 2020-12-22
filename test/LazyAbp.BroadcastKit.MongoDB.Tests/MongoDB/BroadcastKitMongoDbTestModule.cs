using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit.MongoDB
{
    [DependsOn(
        typeof(BroadcastKitTestBaseModule),
        typeof(BroadcastKitMongoDbModule)
        )]
    public class BroadcastKitMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}