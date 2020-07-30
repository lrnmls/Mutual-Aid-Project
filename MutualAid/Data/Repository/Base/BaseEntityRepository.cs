using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.Repository.Base
{
    public abstract class BaseEntityRepository<TType> : BaseRepository<TType> where TType : BaseEntity
    {
        protected BaseEntityRepository(MutualAidContext dbContext) : base(dbContext)
        {
        }
    }
}
