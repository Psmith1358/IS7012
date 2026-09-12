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
    public class DetailsModel : PageModel
    {
        private readonly Exercise2.Data.Exercise2Context _context;

        public DetailsModel(Exercise2.Data.Exercise2Context context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.Id == id);

            if (accountholder is not null)
            {
                AccountHolder = accountholder;

                return Page();
            }

            return NotFound();
        }
    }
}
