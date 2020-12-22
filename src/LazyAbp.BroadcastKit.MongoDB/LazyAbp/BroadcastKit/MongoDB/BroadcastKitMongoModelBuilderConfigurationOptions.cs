using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace LazyAbp.BroadcastKit.MongoDB
{
    public class BroadcastKitMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public BroadcastKitMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}