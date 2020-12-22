using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(BroadcastKitHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BroadcastKitConsoleApiClientModule : AbpModule
    {
        
    }
}
