using AutoMapper;
using Lazy.Abp.BroadcastKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy.Abp.BroadcastKit.Admin
{
    public class BroadcastKitAdminApplicationAutoMapperProfile : Profile
    {
        public BroadcastKitAdminApplicationAutoMapperProfile()
        {
            CreateMap<Broadcast, BroadcastDto>();
            CreateMap<CreateUpdateBroadcastDto, Broadcast>(MemberList.Source);
        }
    }
}
