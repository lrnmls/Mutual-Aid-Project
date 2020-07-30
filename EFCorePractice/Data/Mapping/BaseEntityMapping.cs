using EFCorePractice.Framework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Mapping
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
