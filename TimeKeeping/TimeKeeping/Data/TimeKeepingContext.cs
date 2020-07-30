using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class TimeKeepingContext : DbContext
    {
        public TimeKeepingContext (DbContextOptions<TimeKeepingContext> options)
            : base(options)
        {
        }

        public DbSet<TimeKeeping.Models.Time> Time { get; set; }
    }
}
