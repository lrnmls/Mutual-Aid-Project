using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Mapping
{
    public abstract class BaseAuditableEntityMapping<TEntity> : BaseEntityMapping<TEntity> where TEntity : BaseAuditableEntity
    {
    }
}
