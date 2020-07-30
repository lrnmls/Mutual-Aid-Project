using EFCorePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Mapping
{
    public class OrderMapping : BaseAuditableEntityMapping<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order", "Common");
            base.Configure(builder);
        }
    }
}
