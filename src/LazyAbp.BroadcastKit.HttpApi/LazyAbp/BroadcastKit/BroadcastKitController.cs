using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LazyAbp.BroadcastKit
{
    public abstract class BroadcastKitController : AbpController
    {
        protected BroadcastKitController()
        {
            LocalizationResource = typeof(BroadcastKitResource);
        }
    }
}
