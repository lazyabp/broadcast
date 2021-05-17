using Lazy.Abp.BroadcastKit.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.BroadcastKit.Admin
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
