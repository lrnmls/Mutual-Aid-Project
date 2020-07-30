using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Views.TimeTrack
{
    public class CreateModel : PageModel
    {
        private readonly TimeTracker.Data.TimeTrackerContext _context;

        public CreateModel(TimeTracker.Data.TimeTrackerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Time Time { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Times.Add(Time);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
