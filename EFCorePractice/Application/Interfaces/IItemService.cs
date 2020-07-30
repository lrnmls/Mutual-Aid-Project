using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFCorePractice.Data.DTO;

namespace EFCorePractice.Application.Interfaces
{
    public interface IItemService : IBaseService
    {
        Task<bool> AddItemAsync(ItemDTO item);
        Task<IEnumerable<ItemDTO>> GetAllItemsAsync();
        Task<IEnumerable<ItemDTO>> GetAllItemsByOrderIdAsync(int orderId);
        Task<ItemDTO> GetItemById(int itemId);
    }
}
