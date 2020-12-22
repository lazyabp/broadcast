using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(BroadcastKitApplicationModule),
        typeof(BroadcastKitDomainTestModule)
        )]
    public class BroadcastKitApplicationTestModule : AbpModule
    {

    }
}
