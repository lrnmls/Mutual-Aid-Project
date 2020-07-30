using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.MappingProfiles
{
    public class AcceptedRequestMappingProfile : AutoMapper.Profile
    {
        public AcceptedRequestMappingProfile()
        {
            CreateMap<AcceptedRequestDto, AcceptedRequestViewModel>();
            CreateMap<AcceptedRequestViewModel, AcceptedRequestDto>();
        }
    }
}
