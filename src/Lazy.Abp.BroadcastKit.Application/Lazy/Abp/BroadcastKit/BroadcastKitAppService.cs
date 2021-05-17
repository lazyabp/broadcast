using Lazy.Abp.BroadcastKit.Localization;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.BroadcastKit
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
