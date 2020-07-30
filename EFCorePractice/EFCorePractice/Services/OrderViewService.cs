using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Services
{
    public class OrderViewService : BaseViewService, IOrderViewService
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderViewService(IOrderService orderService, IMapper mapper) : base(mapper, orderService)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        public async Task<bool> AddOrderAsync(OrderViewModel model)
        {
            var orderEntity = mapper.Map<OrderDTO>(model);
            var orderResult = await orderService.AddOrderAsync(orderEntity);

            if (!orderResult)
            {
                return false;
            }
            return orderResult;
        }

        public async Task<IEnumerable<OrderViewModel>> GetAllOrdersAsync()
        {
            var orders = await orderService.GetAllOrdersAsync();
            return mapper.Map<IEnumerable<OrderViewModel>>(orders);
        }

        public async Task<IEnumerable<OrderViewModel>> GetAllOrdersByUserIdAsync(int userId)
        {
            var orders = await orderService.GetAllOrdersByUserIdAsync(userId);
            return mapper.Map<IEnumerable<OrderViewModel>>(orders);
        }

        public async Task<OrderViewModel> GetOrderByIdAsync(int orderId)
        {
            var order = await orderService.GetOrderById(orderId);
            return mapper.Map<OrderViewModel>(order);
        }
    }
}
