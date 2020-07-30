using EFCorePractice.Data.DTO;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.MappingProfiles
{
    public class OrderMappingProfile : AutoMapper.Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderDTO, OrderViewModel>();
            CreateMap<OrderViewModel, OrderDTO>();
        }
    }
}
