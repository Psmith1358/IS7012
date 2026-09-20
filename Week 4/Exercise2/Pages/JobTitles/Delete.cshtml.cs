using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly Exercise2.Data.ApplicationDbContext _context;

        public DeleteModel(Exercise2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitles.FirstOrDefaultAsync(m => m.Id == id);

            if (jobtitle is not null)
            {
                JobTitle = jobtitle;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitles.FindAsync(id);
            if (jobtitle != null)
            {
                JobTitle = jobtitle;
                _context.JobTitles.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
