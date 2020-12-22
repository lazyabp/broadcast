using LazyAbp.BroadcastKit;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LazyAbp.BroadcastKit.EntityFrameworkCore
{
    public static class BroadcastKitDbContextModelCreatingExtensions
    {
        public static void ConfigureBroadcastKit(
            this ModelBuilder builder,
            Action<BroadcastKitModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BroadcastKitModelBuilderConfigurationOptions(
                BroadcastKitDbProperties.DbTablePrefix,
                BroadcastKitDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Broadcast>(b =>
            {
                b.ToTable(options.TablePrefix + "Broadcasts", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
