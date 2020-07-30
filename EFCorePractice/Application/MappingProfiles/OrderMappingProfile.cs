using AutoMapper;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Application.MappingProfiles
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
