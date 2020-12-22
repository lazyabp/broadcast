using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace LazyAbp.BroadcastKit
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class BroadcastKitDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BroadcastKitDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<BroadcastKitResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/LazyAbp/BroadcastKit/Localization");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("BroadcastKit", typeof(BroadcastKitResource));
            });
        }
    }
}
