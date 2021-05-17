using Lazy.Abp.BroadcastKit.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lazy.Abp.BroadcastKit.Admin.Permissions
{
    public class BroadcastKitAdminPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BroadcastKitAdminPermissions.GroupName, L("Permission:BroadcastKitAdmin"));

            var broadcastPermission = myGroup.AddPermission(BroadcastKitAdminPermissions.Broadcast.Default, L("Permission:Broadcast"));
            broadcastPermission.AddChild(BroadcastKitAdminPermissions.Broadcast.Create, L("Permission:Create"));
            broadcastPermission.AddChild(BroadcastKitAdminPermissions.Broadcast.Update, L("Permission:Update"));
            broadcastPermission.AddChild(BroadcastKitAdminPermissions.Broadcast.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BroadcastKitResource>(name);
        }
    }
}
