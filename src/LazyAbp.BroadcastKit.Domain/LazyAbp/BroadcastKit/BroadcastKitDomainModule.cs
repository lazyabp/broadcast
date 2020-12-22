using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(BroadcastKitDomainSharedModule)
    )]
    public class BroadcastKitDomainModule : AbpModule
    {

    }
}
