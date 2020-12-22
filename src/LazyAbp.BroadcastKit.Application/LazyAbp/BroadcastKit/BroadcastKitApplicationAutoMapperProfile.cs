using LazyAbp.BroadcastKit;
using LazyAbp.BroadcastKit.Dtos;
using AutoMapper;

namespace LazyAbp.BroadcastKit
{
    public class BroadcastKitApplicationAutoMapperProfile : Profile
    {
        public BroadcastKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Broadcast, BroadcastDto>();
            CreateMap<CreateUpdateBroadcastDto, Broadcast>(MemberList.Source);
        }
    }
}
