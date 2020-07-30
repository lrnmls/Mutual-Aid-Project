using EFCorePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Data.Context
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema("Common");
            base.OnModelCreating(modelBuilder);
        }
    }
}
