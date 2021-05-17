using System;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.BroadcastKit.Dtos
{
    [Serializable]
    public class BroadcastViewDto : CreationAuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string FullDescription { get; set; }

        public bool IsActive { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ExpireTime { get; set; }
    }
}