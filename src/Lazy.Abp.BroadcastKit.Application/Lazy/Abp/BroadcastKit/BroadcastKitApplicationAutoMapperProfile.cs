using Lazy.Abp.BroadcastKit;
using Lazy.Abp.BroadcastKit.Dtos;
using AutoMapper;

namespace Lazy.Abp.BroadcastKit
{
    public class BroadcastKitApplicationAutoMapperProfile : Profile
    {
        public BroadcastKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Broadcast, BroadcastViewDto>();
        }
    }
}
