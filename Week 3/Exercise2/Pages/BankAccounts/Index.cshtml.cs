using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly Exercise2.Data.Exercise2Context _context;

        public IndexModel(Exercise2.Data.Exercise2Context context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
