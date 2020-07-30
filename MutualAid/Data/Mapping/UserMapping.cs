using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.Mapping
{
    public class UserMapping : BaseEntityMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Salt).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.County).IsRequired();
            //builder.HasOne(x => x.Requests).WithOne().HasForeignKey<Request>(x => x.UserId);
            //builder.HasOne(x => x.AcceptedRequests).WithOne().HasForeignKey<AcceptedRequest>(x => x.UserId);

            builder.ToTable("User");

            base.Configure(builder);
        }
    }
}
