using System;
using Lazy.Abp.BroadcastKit.Permissions;
using Lazy.Abp.BroadcastKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using Volo.Abp;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Lazy.Abp.BroadcastKit
{
    public class BroadcastAppService : ApplicationService, IBroadcastAppService
    {
        private readonly IBroadcastRepository _repository;
        
        public BroadcastAppService(IBroadcastRepository repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        public async Task<BroadcastViewDto> GetPublishedAsync(Guid id)
        {
            var broadcast = await _repository.GetAsync(id);

            if (broadcast.IsActive)
                return ObjectMapper.Map<Broadcast, BroadcastViewDto>(broadcast);
            else
                throw new UserFriendlyException(L["NoFoundRecord"]);
        }

        [AllowAnonymous]
        public async Task<PagedResultDto<BroadcastViewDto>> GetPublishedListAsync(PagedAndSortedResultRequestDto input)
        {
            var totalcount = await _repository.GetCountAsync(true, null, null, null, Clock.Now, null);
            var broadcasts = await _repository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount, true, null, null, null, Clock.Now, null);

            return new PagedResultDto<BroadcastViewDto>(
                    totalcount,
                    ObjectMapper.Map<List<Broadcast>, List<BroadcastViewDto>>(broadcasts)
                );
        }
    }
}
