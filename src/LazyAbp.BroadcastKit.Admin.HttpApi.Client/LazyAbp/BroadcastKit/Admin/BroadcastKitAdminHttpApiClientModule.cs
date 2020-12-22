using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit.Admin
{
    [DependsOn(
        typeof(BroadcastKitAdminApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BroadcastKitAdminHttpApiClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(typeof(BroadcastKitAdminApplicationContractsModule).Assembly,
                BroadcastKitAdminRemoteServiceConsts.RemoteServiceName);
        }
    }
}
