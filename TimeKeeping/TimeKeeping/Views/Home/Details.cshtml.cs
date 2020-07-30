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
    public class DetailsModel : PageModel
    {
        private readonly TimeKeeping.Data.TimeKeepingContext _context;

        public DetailsModel(TimeKeeping.Data.TimeKeepingContext context)
        {
            _context = context;
        }

        public Time Time { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Time = await _context.Time.FirstOrDefaultAsync(m => m.ID == id);

            if (Time == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
