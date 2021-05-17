namespace Lazy.Abp.BroadcastKit
{
    public static class BroadcastKitDbProperties
    {
        public static string DbTablePrefix { get; set; } = "BroadcastKit";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "BroadcastKit";
    }
}
