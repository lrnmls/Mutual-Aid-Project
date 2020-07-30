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
    public class ItemService : BaseService<Item>, IItemService
    {
        private readonly IItemRepository itemRepository;
        private readonly IMapper mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper) : base(itemRepository, mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AddItemAsync(ItemDTO item)
        {
            var itemEntity = mapper.Map<Item>(item);
            var itemResult = await itemRepository.AddAsync(itemEntity);

            if (!itemResult)
            {
                return false;
            }
            return itemResult;
        }

        public async Task<IEnumerable<ItemDTO>> GetAllItemsAsync()
        {
            var items = await itemRepository.GetAllAsync();
            return mapper.Map<IEnumerable<ItemDTO>>(items);
        }

        public async Task<IEnumerable<ItemDTO>> GetAllItemsByOrderIdAsync(int orderId)
        {
            var items = await itemRepository.GetAllItemsByOrderIdAsync(orderId);
            return mapper.Map<IEnumerable<ItemDTO>>(items);
        }

        public async Task<ItemDTO> GetItemById(int itemId)
        {
            var item = await itemRepository.GetByIdAsync(itemId);
            return mapper.Map<ItemDTO>(item);
        }
    }
}
