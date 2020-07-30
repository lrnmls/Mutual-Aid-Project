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
    public class DeleteModel : PageModel
    {
        private readonly TimeKeeping.Data.TimeKeepingContext _context;

        public DeleteModel(TimeKeeping.Data.TimeKeepingContext context)
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

            Time = await _context.Time.FirstOrDefaultAsync(m => m.ID == id);

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

            Time = await _context.Time.FindAsync(id);

            if (Time != null)
            {
                _context.Time.Remove(Time);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
