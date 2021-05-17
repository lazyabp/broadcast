using Localization.Resources.AbpUi;
using Lazy.Abp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lazy.Abp.BroadcastKit
{
    [DependsOn(
        typeof(BroadcastKitApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BroadcastKitHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BroadcastKitHttpApiModule).Assembly);
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
