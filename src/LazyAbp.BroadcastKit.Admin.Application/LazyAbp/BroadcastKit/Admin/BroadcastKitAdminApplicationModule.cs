using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit.Admin
{
    [DependsOn(
        typeof(BroadcastKitDomainModule),
        typeof(BroadcastKitAdminApplicationContractsModule),
        typeof(AbpCachingModule),
        typeof(AbpAutoMapperModule))]
    public class BroadcastKitAdminApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<BroadcastKitAdminApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BroadcastKitAdminApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
