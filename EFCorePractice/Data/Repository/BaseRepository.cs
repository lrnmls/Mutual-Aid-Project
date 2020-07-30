using EFCorePractice.Data.Context;
using EFCorePractice.Data.Interfaces;
using EFCorePractice.Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Repository
{
    public class BaseRepository<TType> : IBaseRepository<TType> where TType :BaseEntity
    {
        protected readonly PracticeContext DbContext;

        public BaseRepository(PracticeContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<bool> AddAsync(TType entity)
        {
            DbContext.Set<TType>().Add(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<IReadOnlyList<TType>> GetAllAsync()
        {
            return await DbContext.Set<TType>().ToListAsync();
        }

        public async Task<TType> GetByIdAsync(int id)
        {
            return await DbContext.Set<TType>().FindAsync(id);
        }
    }
}
