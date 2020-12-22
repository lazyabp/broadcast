using Volo.Abp.Reflection;

namespace LazyAbp.BroadcastKit.Permissions
{
    public class BroadcastKitPermissions
    {
        public const string GroupName = "BroadcastKit";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BroadcastKitPermissions));
        }
    }
}
