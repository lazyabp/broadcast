using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LazyAbp.BroadcastKit.EntityFrameworkCore
{
    public class BroadcastKitModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public BroadcastKitModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}