
using EFCorePractice.Data.DTO;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.MappingProfiles
{
    public class UserMappingProfile : AutoMapper.Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserDTO, UserViewModel>();
            CreateMap<UserViewModel, UserDTO>();
        }
    }
}
