using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Services
{
    public class ItemViewService : BaseViewService, IItemViewService
    {
        private readonly IItemService itemService;
        private readonly IMapper mapper;

        public ItemViewService(IItemService itemService, IMapper mapper) : base(mapper, itemService)
        {
            this.itemService = itemService;
            this.mapper = mapper;
        }

        public async Task<bool> AddItemAsync(ItemViewModel model)
        {
            var itemEntity = mapper.Map<ItemDTO>(model);
            var itemResult = await itemService.AddItemAsync(itemEntity);

            if (!itemResult)
            {
                return false;
            }
            return itemResult;
        }

        public async Task<IEnumerable<ItemViewModel>> GetAllItemsAsync()
        {
            var items = await itemService.GetAllItemsAsync();
            return mapper.Map<IEnumerable<ItemViewModel>>(items);
        }

        public async Task<IEnumerable<ItemViewModel>> GetAllItemsByOrderIdAsync(int orderId)
        {
            var items = await itemService.GetAllItemsByOrderIdAsync(orderId);
            return mapper.Map<IEnumerable<ItemViewModel>>(items);
        }

        public async Task<ItemViewModel> GetItemByIdAsync(int itemId)
        {
            var item = await itemService.GetItemById(itemId);
            return mapper.Map<ItemViewModel>(item);
        }
    }
}
