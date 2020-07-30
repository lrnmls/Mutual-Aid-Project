using EFCorePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.Mapping
{
    public class ItemMapping : BaseAuditableEntityMapping<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item", "Common");
            base.Configure(builder);
        }
    }
}
