using LazyAbp.BroadcastKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace LazyAbp.BroadcastKit.Admin
{
    public interface IBroadcastManagementAppService :
        ICrudAppService<
            BroadcastDto,
            Guid,
            GetBroadcastListInput,
            CreateUpdateBroadcastDto,
            CreateUpdateBroadcastDto>
    {
    }
}
