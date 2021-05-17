using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lazy.Abp.BroadcastKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(BroadcastKitDomainSharedModule)
    )]
    public class BroadcastKitDomainModule : AbpModule
    {

    }
}
