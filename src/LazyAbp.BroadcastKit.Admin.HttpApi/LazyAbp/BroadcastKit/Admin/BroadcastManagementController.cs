using LazyAbp.BroadcastKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace LazyAbp.BroadcastKit.Admin
{
    [RemoteService(Name = BroadcastKitAdminRemoteServiceConsts.RemoteServiceName)]
    [Area("broadcastkitadmin")]
    [ControllerName("Broadcast")]
    [Route("api/broadcastkit/broadcasts/admin")]
    public class BroadcastManagementController : AbpController, IBroadcastManagementAppService
    {
        private readonly IBroadcastManagementAppService _service;

        public BroadcastManagementController(IBroadcastManagementAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<BroadcastDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<BroadcastDto>> GetListAsync(GetBroadcastListInput input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<BroadcastDto> CreateAsync(CreateUpdateBroadcastDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<BroadcastDto> UpdateAsync(Guid id, CreateUpdateBroadcastDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}
