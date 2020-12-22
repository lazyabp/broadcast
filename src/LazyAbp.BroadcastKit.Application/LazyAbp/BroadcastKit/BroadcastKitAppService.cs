using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.Application.Services;

namespace LazyAbp.BroadcastKit
{
    public abstract class BroadcastKitAppService : ApplicationService
    {
        protected BroadcastKitAppService()
        {
            LocalizationResource = typeof(BroadcastKitResource);
            ObjectMapperContext = typeof(BroadcastKitApplicationModule);
        }
    }
}
