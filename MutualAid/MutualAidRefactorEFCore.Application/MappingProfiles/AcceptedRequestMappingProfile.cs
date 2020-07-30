using AutoMapper;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Application.MappingProfiles
{
    public class AcceptedRequestMappingProfile : Profile
    {
        public AcceptedRequestMappingProfile()
        {
            CreateMap<AcceptedRequest, AcceptedRequestDto>();
            CreateMap<AcceptedRequestDto, AcceptedRequest>();
        }
    }
}
