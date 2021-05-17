using Lazy.Abp.BroadcastKit.Localization;
using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Lazy.Abp.BroadcastKit.Admin
{
    [DependsOn(
        typeof(BroadcastKitAdminApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BroadcastKitAdminHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BroadcastKitAdminHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BroadcastKitResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
