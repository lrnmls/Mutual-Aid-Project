using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using MutualAidRefactorEFCore.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Context
{
    public class MutualAidContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Request> Requests { get; set; }
        //public DbSet<AcceptedRequest> AcceptedRequests { get; set; }

        public MutualAidContext(DbContextOptions<MutualAidContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            //modelBuilder.HasDefaultSchema("Common");
            base.OnModelCreating(modelBuilder);
        }
    }
}
