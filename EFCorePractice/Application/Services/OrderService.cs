using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Application.Services
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IMapper mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AddOrderAsync(OrderDTO order)
        {
            var orderEntity = mapper.Map<Order>(order);
            var orderResult = await orderRepository.AddAsync(orderEntity);

            if (!orderResult)
            {
                return false;
            }
            return orderResult;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await orderRepository.GetAllAsync();
            return mapper.Map<IEnumerable<OrderDTO>>(orders);
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrdersByUserIdAsync(int userId)
        {
            var orders = await orderRepository.GetAllOrdersByUserIdAsync(userId);
            return mapper.Map<IEnumerable<OrderDTO>>(orders);
        }

        public async Task<OrderDTO> GetOrderById(int orderId)
        {
            var order = await orderRepository.GetByIdAsync(orderId);
            return mapper.Map<OrderDTO>(order);
        }
    }
}
