using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(BroadcastKitDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class BroadcastKitApplicationContractsModule : AbpModule
    {

    }
}
