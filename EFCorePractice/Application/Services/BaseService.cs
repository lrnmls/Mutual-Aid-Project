using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Interfaces;
using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Application.Services
{
    public abstract class BaseService<TEntity> : IBaseService where TEntity : BaseEntity
    {
        protected readonly IMapper Mapper;
        private readonly IBaseRepository<TEntity> _baseEntityRepository;

        protected BaseService(IBaseRepository<TEntity> baseEntityRepository, IMapper Mapper)
        {
            _baseEntityRepository = baseEntityRepository;
        }

        public virtual async Task<IEnumerable<DropdownDTO>> GetDropdownDtosAsync()
        {
            var entities = await _baseEntityRepository.GetAllAsync();
            return Mapper.Map<IEnumerable<DropdownDTO>>(entities);
        }
    }
}
