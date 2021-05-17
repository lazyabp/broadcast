using Lazy.Abp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.BroadcastKit
{
    public abstract class BroadcastKitController : AbpController
    {
        protected BroadcastKitController()
        {
            LocalizationResource = typeof(BroadcastKitResource);
        }
    }
}
