using EFCorePractice.Data.Context;
using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Repository
{
    public abstract class BaseEntityRepository<TType> : BaseRepository<TType> where TType : BaseEntity
    {
        protected BaseEntityRepository(PracticeContext dbContext) : base(dbContext)
        {
        }
    }
}
