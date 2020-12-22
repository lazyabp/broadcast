using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace LazyAbp.BroadcastKit
{
    public class BroadcastAppServiceTests : BroadcastKitApplicationTestBase
    {
        private readonly IBroadcastAppService _broadcastAppService;

        public BroadcastAppServiceTests()
        {
            _broadcastAppService = GetRequiredService<IBroadcastAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
