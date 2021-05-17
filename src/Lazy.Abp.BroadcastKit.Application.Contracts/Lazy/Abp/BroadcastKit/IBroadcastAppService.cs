using System;
using System.Threading.Tasks;
using Lazy.Abp.BroadcastKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Lazy.Abp.BroadcastKit
{
    public interface IBroadcastAppService : IApplicationService, ITransientDependency
    {
        Task<BroadcastViewDto> GetPublishedAsync(Guid id);

        Task<PagedResultDto<BroadcastViewDto>> GetPublishedListAsync(PagedAndSortedResultRequestDto input);
    }
}