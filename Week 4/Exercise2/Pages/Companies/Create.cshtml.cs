using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_Companies
{
    public class CreateModel : PageModel
    {
        private readonly Exercise2.Data.ApplicationDbContext _context;

        public CreateModel(Exercise2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryId"] = new SelectList(_context.Industries, "Id", "IndustryName");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Companies.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
