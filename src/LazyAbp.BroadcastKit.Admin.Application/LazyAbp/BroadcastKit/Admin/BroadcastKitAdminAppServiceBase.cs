using LazyAbp.BroadcastKit.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace LazyAbp.BroadcastKit.Admin
{
    public abstract class BroadcastKitAdminAppServiceBase : ApplicationService
    {
        protected BroadcastKitAdminAppServiceBase()
        {
            ObjectMapperContext = typeof(BroadcastKitAdminApplicationModule);
            LocalizationResource = typeof(BroadcastKitResource);
        }
    }
}
