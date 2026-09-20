using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_Companies
{
    public class IndexModel : PageModel
    {
        private readonly Exercise2.Data.ApplicationDbContext _context;

        public IndexModel(Exercise2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Companies
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
