using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LazyAbp.BroadcastKit.Permissions
{
    public class BroadcastKitPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BroadcastKitPermissions.GroupName, L("Permission:BroadcastKit"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BroadcastKitResource>(name);
        }
    }
}
