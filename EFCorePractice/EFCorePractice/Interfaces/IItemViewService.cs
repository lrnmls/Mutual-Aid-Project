using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Interfaces
{
    public interface IItemViewService : IBaseViewService
    {
        Task<bool> AddItemAsync(ItemViewModel model);
        Task<IEnumerable<ItemViewModel>> GetAllItemsAsync();
        Task<IEnumerable<ItemViewModel>> GetAllItemsByOrderIdAsync(int orderId);
        Task<ItemViewModel> GetItemByIdAsync(int itemId);
    }
}
