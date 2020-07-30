using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Services
{
    public class BaseViewService : IBaseViewService
    {
        protected readonly IMapper Mapper;
        private readonly IBaseService _baseService;

        public BaseViewService(IMapper mapper, IBaseService baseService)
        {
            Mapper = mapper;
            _baseService = baseService;
        }


        public virtual async Task<IEnumerable<DropdownViewModel>> GetDropdownViewModelsAsync()
        {
            var dtos = await _baseService.GetDropdownDtosAsync();
            return Mapper.Map<IEnumerable<DropdownViewModel>>(dtos);
        }
    }
}
