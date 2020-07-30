using AutoMapper;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemViewService itemViewService;
        private readonly IMapper mapper;

        public ItemController(IItemViewService itemViewService, IMapper mapper)
        {
            this.itemViewService = itemViewService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> ViewItems()
        {
            var items = await itemViewService.GetAllItemsAsync();
            return View(items);
        }
    }
}
