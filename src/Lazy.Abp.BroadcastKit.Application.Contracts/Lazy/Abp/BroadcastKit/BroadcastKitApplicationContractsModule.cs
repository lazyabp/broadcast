using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lazy.Abp.BroadcastKit
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
