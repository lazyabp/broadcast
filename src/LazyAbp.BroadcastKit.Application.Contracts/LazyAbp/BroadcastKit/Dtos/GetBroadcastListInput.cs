using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.BroadcastKit.Dtos
{
    public class GetBroadcastListInput : PagedAndSortedResultRequestDto
    {
        public bool? IsActive { get; set; }

        public DateTime? StartAfter { get; set; }

        public DateTime? StartBefore { get; set; }

        public DateTime? ExpireAfter { get; set; }

        public DateTime? ExpireBefore { get; set; }

        public string Filter { get; set; }
    }
}
