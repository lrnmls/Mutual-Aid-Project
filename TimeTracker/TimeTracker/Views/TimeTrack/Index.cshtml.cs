using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Views.TimeTrack
{
    public class IndexModel : PageModel
    {
        private readonly TimeTracker.Data.TimeTrackerContext _context;

        public IndexModel(TimeTracker.Data.TimeTrackerContext context)
        {
            _context = context;
        }

        public IList<Time> Time { get;set; }

        public async Task OnGetAsync()
        {
            Time = await _context.Times.ToListAsync();
        }
    }
}
