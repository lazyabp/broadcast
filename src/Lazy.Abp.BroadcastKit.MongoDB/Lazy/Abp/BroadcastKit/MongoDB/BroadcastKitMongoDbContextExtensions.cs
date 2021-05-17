using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.BroadcastKit.MongoDB
{
    public static class BroadcastKitMongoDbContextExtensions
    {
        public static void ConfigureBroadcastKit(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BroadcastKitMongoModelBuilderConfigurationOptions(
                BroadcastKitDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}