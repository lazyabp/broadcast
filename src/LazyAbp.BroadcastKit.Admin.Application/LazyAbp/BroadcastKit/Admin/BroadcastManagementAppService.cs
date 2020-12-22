using LazyAbp.BroadcastKit.Admin.Permissions;
using LazyAbp.BroadcastKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LazyAbp.BroadcastKit.Admin
{
    public class BroadcastManagementAppService :
        CrudAppService<
            Broadcast, 
            BroadcastDto, 
            Guid, 
            GetBroadcastListInput, 
            CreateUpdateBroadcastDto, 
            CreateUpdateBroadcastDto>,
        IBroadcastManagementAppService
    {
        protected override string GetListPolicyName { get; set; } = BroadcastKitAdminPermissions.Broadcast.Default;
        protected override string CreatePolicyName { get; set; } = BroadcastKitAdminPermissions.Broadcast.Create;
        protected override string UpdatePolicyName { get; set; } = BroadcastKitAdminPermissions.Broadcast.Update;
        protected override string DeletePolicyName { get; set; } = BroadcastKitAdminPermissions.Broadcast.Delete;

        private readonly IBroadcastRepository _repository;

        public BroadcastManagementAppService(IBroadcastRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async override Task<PagedResultDto<BroadcastDto>> GetListAsync(GetBroadcastListInput input)
        {
            var totalcount = await _repository.GetCountAsync(input.IsActive, input.StartAfter, input.StartBefore,
                input.ExpireAfter, input.ExpireBefore, input.Filter);

            var broadcasts = await _repository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount,
                input.IsActive, input.StartAfter, input.StartBefore, input.ExpireAfter, input.ExpireBefore, input.Filter);

            return new PagedResultDto<BroadcastDto>(
                    totalcount,
                    ObjectMapper.Map<List<Broadcast>, List<BroadcastDto>>(broadcasts)
                );
        }
    }
}
