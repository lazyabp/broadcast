using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.BroadcastKit.EntityFrameworkCore
{
    public class BroadcastKitHttpApiHostMigrationsDbContext : AbpDbContext<BroadcastKitHttpApiHostMigrationsDbContext>
    {
        public BroadcastKitHttpApiHostMigrationsDbContext(DbContextOptions<BroadcastKitHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBroadcastKit();
        }
    }
}
