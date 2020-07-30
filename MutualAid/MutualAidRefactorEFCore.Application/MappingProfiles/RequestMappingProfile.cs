using AutoMapper;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Application.MappingProfiles
{
    public class RequestMappingProfile : Profile
    {
        public RequestMappingProfile()
        {
            CreateMap<Request, RequestDto>();
            CreateMap<RequestDto, Request>();
        }
    }
}
