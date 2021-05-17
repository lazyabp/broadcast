using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lazy.Abp.BroadcastKit;

namespace Lazy.Abp.BroadcastKit.EntityFrameworkCore
{
    [ConnectionStringName(BroadcastKitDbProperties.ConnectionStringName)]
    public class BroadcastKitDbContext : AbpDbContext<BroadcastKitDbContext>, IBroadcastKitDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Broadcast> Broadcasts { get; set; }

        public BroadcastKitDbContext(DbContextOptions<BroadcastKitDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBroadcastKit();
        }
    }
}
