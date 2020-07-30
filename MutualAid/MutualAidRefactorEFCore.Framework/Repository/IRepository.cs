using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Framework.Repository
{
    public interface IRepository<T> where T: IEntity
    {
        //get
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();

        //post
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
