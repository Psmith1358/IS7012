using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_Candidates
{
    public class IndexModel : PageModel
    {
        private readonly Exercise2.Data.ApplicationDbContext _context;

        public IndexModel(Exercise2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidates
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
