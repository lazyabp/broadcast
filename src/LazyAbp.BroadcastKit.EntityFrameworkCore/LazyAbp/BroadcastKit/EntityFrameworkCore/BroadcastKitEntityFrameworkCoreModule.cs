using LazyAbp.BroadcastKit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit.EntityFrameworkCore
{
    [DependsOn(
        typeof(BroadcastKitDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class BroadcastKitEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BroadcastKitDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Broadcast, BroadcastRepository>();
            });
        }
    }
}
