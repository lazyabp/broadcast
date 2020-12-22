using Localization.Resources.AbpUi;
using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace LazyAbp.BroadcastKit
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
