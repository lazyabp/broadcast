using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace LazyAbp.BroadcastKit.Admin
{
    [DependsOn(typeof(BroadcastKitDomainSharedModule))]
    public class BroadcastKitAdminApplicationContractsModule : AbpModule
    {
    }
}
