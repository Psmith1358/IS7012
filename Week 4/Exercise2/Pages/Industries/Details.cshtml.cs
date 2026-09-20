using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_Industries
{
    public class DetailsModel : PageModel
    {
        private readonly Exercise2.Data.ApplicationDbContext _context;

        public DetailsModel(Exercise2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industries.FirstOrDefaultAsync(m => m.Id == id);

            if (industry is not null)
            {
                Industry = industry;

                return Page();
            }

            return NotFound();
        }
    }
}
