using LazyAbp.BroadcastKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.BroadcastKit
{
    [RemoteService(Name = BroadcastKitRemoteServiceConsts.RemoteServiceName)]
    [Area("broadcastkit")]
    [ControllerName("Broadcast")]
    [Route("api/broadcastkit/broadcasts")]
    public class BroadcastController : BroadcastKitController, IBroadcastAppService
    {
        private readonly IBroadcastAppService _broadcastAppService;

        public BroadcastController(IBroadcastAppService broadcastAppService)
        {
            _broadcastAppService = broadcastAppService;
        }

        [HttpGet]
        [Route("published/{id}")]
        public Task<BroadcastViewDto> GetPublishedAsync(Guid id)
        {
            return _broadcastAppService.GetPublishedAsync(id);
        }

        [HttpGet]
        [Route("published")]
        public Task<PagedResultDto<BroadcastViewDto>> GetPublishedListAsync(PagedAndSortedResultRequestDto input)
        {
            return _broadcastAppService.GetPublishedListAsync(input);
        }
    }
}
