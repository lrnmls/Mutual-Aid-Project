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
    public class DeleteModel : PageModel
    {
        private readonly TimeTracker.Data.TimeTrackerContext _context;

        public DeleteModel(TimeTracker.Data.TimeTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Time Time { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Time = await _context.Times.FirstOrDefaultAsync(m => m.ID == id);

            if (Time == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Time = await _context.Times.FindAsync(id);

            if (Time != null)
            {
                _context.Times.Remove(Time);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
