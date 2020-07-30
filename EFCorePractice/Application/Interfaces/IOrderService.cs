using EFCorePractice.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Application.Interfaces
{
    public interface IOrderService : IBaseService
    {
        Task<bool> AddOrderAsync(OrderDTO order);
        Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
        Task<IEnumerable<OrderDTO>> GetAllOrdersByUserIdAsync(int userId);
        Task<OrderDTO> GetOrderById(int orderId);
    }
}
