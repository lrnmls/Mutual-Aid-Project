using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Interfaces
{
    public interface IOrderViewService : IBaseViewService
    {
        Task<bool> AddOrderAsync(OrderViewModel model);
        Task<IEnumerable<OrderViewModel>> GetAllOrdersAsync();
        Task<IEnumerable<OrderViewModel>> GetAllOrdersByUserIdAsync(int userId);
        Task<OrderViewModel> GetOrderByIdAsync(int orderId);
    }
}
