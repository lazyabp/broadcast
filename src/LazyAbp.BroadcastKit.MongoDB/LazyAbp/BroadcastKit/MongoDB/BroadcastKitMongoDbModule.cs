using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace LazyAbp.BroadcastKit.MongoDB
{
    [DependsOn(
        typeof(BroadcastKitDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class BroadcastKitMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<BroadcastKitMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
