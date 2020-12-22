using LazyAbp.BroadcastKit.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(BroadcastKitEntityFrameworkCoreTestModule)
        )]
    public class BroadcastKitDomainTestModule : AbpModule
    {
        
    }
}
