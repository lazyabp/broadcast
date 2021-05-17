using System;
using System.ComponentModel;
namespace Lazy.Abp.BroadcastKit.Dtos
{
    [Serializable]
    public class CreateUpdateBroadcastDto
    {
        [DisplayName("BroadcastTitle")]
        public string Title { get; set; }

        [DisplayName("BroadcastFullDescription")]
        public string FullDescription { get; set; }

        [DisplayName("BroadcastIsActive")]
        public bool IsActive { get; set; }

        [DisplayName("BroadcastStartTime")]
        public DateTime StartTime { get; set; }

        [DisplayName("BroadcastExpireTime")]
        public DateTime ExpireTime { get; set; }
    }
}