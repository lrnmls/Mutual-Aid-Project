using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Models;

namespace TimeTracker.Data
{
    public class TimeTrackerContext : DbContext
    {
        public TimeTrackerContext (DbContextOptions<TimeTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Time> Times { get; set; }
        public DbSet<TimeCode> TimeCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Time>().ToTable("Time");
            modelBuilder.Entity<TimeCode>().ToTable("TimeCode");
        }

    }
}
