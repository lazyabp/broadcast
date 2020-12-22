using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Reflection;

namespace LazyAbp.BroadcastKit.Admin.Permissions
{
    public class BroadcastKitAdminPermissions
    {
        public const string GroupName = "BroadcastKit.Admin";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BroadcastKitAdminPermissions));
        }

        public class Broadcast
        {
            public const string Default = GroupName + ".Broadcast";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
