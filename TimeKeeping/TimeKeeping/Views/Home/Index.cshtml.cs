using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeKeeping.Data;
using TimeKeeping.Models;

namespace TimeKeeping.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly TimeKeeping.Data.TimeKeepingContext _context;

        public IndexModel(TimeKeeping.Data.TimeKeepingContext context)
        {
            _context = context;
        }

        public IList<Time> Time { get;set; }

        public async Task OnGetAsync()
        {
            Time = await _context.Time.ToListAsync();
        }
    }
}
