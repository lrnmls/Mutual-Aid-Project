using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.MappingProfiles
{
    public class UserMappingProfile : AutoMapper.Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserDto, UserViewModel>();
            CreateMap<UserViewModel, UserDto>();
            CreateMap<RegisterViewModel, UserDto>();
            CreateMap<UserDto, RegisterViewModel>();
        }
    }
}
