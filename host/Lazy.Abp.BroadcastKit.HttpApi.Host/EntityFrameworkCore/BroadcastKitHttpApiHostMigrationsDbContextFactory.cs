using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lazy.Abp.BroadcastKit.EntityFrameworkCore
{
    public class BroadcastKitHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BroadcastKitHttpApiHostMigrationsDbContext>
    {
        public BroadcastKitHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BroadcastKitHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("BroadcastKit"));

            return new BroadcastKitHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
