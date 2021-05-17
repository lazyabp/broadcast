using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Lazy.Abp.BroadcastKit.Admin
{
    [DependsOn(typeof(BroadcastKitDomainSharedModule))]
    public class BroadcastKitAdminApplicationContractsModule : AbpModule
    {
    }
}
