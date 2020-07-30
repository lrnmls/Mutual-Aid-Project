using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Interfaces
{
    public interface IBaseRepository<TType> where TType : BaseEntity
    {
        Task<bool> AddAsync(TType entity);
        Task<IReadOnlyList<TType>> GetAllAsync();
        Task<TType> GetByIdAsync(int id);
    }
}
