using System;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.BroadcastKit.Dtos
{
    [Serializable]
    public class BroadcastDto : FullAuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string FullDescription { get; set; }

        public bool IsActive { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ExpireTime { get; set; }
    }
}