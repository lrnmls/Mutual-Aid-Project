using EFCorePractice.Data.DTO;
using EFCorePractice.UI.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.MappingProfiles
{
    public class ItemMappingProfile : AutoMapper.Profile
    {
        public ItemMappingProfile()
        {
            CreateMap<ItemDTO, ItemViewModel>();
            CreateMap<ItemViewModel, ItemDTO>();
        }
    }
}
