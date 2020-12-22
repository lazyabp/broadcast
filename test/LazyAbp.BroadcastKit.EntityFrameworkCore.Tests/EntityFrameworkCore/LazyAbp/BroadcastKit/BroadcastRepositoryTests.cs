using System;
using System.Threading.Tasks;
using LazyAbp.BroadcastKit;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace LazyAbp.BroadcastKit.EntityFrameworkCore.LazyAbp.BroadcastKit
{
    public class BroadcastRepositoryTests : BroadcastKitEntityFrameworkCoreTestBase
    {
        private readonly IBroadcastRepository _broadcastRepository;

        public BroadcastRepositoryTests()
        {
            _broadcastRepository = GetRequiredService<IBroadcastRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
