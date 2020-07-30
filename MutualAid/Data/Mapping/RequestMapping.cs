using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.Mapping
{
    public class RequestMapping : BaseEntityMapping<Request>
    {
        public override void Configure(EntityTypeBuilder<Request> builder)
        {
            //builder.HasOne(x => x.User).WithOne().HasForeignKey<Request>(x => x.UserId);
            builder.ToTable("Request");

            base.Configure(builder);
        }
    }
}
