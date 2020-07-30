using AutoMapper;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Application.MappingProfiles
{
    public class ItemMappingProfile : Profile
    {
        public ItemMappingProfile()
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<ItemDTO, Item>();
        }
    }
}
