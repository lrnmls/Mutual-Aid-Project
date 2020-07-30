using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Views.TimeTrack
{
    public class EditModel : PageModel
    {
        private readonly TimeTracker.Data.TimeTrackerContext _context;

        public EditModel(TimeTracker.Data.TimeTrackerContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Time).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeExists(Time.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TimeExists(int id)
        {
            return _context.Times.Any(e => e.ID == id);
        }
    }
}
