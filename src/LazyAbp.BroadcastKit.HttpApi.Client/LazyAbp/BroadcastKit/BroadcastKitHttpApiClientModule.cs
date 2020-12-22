using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(BroadcastKitApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BroadcastKitHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BroadcastKit";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BroadcastKitApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
