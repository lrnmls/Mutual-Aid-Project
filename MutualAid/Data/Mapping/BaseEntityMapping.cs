using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.Mapping
{
    public abstract class BaseEntityMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property<bool>("IsDeleted");
            builder.HasQueryFilter(x => EF.Property<bool>(x, "IsDeleted") == false);
        }
    }
}
