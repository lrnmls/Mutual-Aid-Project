using EFCorePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Mapping
{
    public class UserMapping : BaseAuditableEntityMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.ToTable("User", "Common");
            base.Configure(builder);
        }
    }
}
