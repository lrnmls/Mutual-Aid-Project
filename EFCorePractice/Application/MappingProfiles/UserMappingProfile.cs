using AutoMapper;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Application.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
