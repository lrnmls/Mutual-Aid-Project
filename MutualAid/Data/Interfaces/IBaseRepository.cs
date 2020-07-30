using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Interfaces
{
    public interface IBaseRepository<TType> where TType : BaseEntity
    {
        //get
        Task<TType> GetByIdAsync(int id);
        Task<IReadOnlyList<TType>> GetAllAsync();

        //post
        Task<bool> AddAsync(TType entity);
        Task<bool> UpdateAsync(TType entity);
        Task<bool> DeleteAsync(TType entity);
    }
}
