using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_AccountHolders
{
    public class IndexModel : PageModel
    {
        private readonly Exercise2.Data.Exercise2Context _context;

        public IndexModel(Exercise2.Data.Exercise2Context context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AccountHolder = await _context.AccountHolder.ToListAsync();
        }
    }
}
