using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.Mapping
{
    public class AcceptedRequestMapping : BaseEntityMapping<AcceptedRequest>
    {
        public override void Configure(EntityTypeBuilder<AcceptedRequest> builder)
        {
            //builder.HasOne(x => x.User).WithOne().HasForeignKey<AcceptedRequest>(x => x.UserId);
            builder.ToTable("Accepted Request");

            base.Configure(builder);
        }
    }
}
