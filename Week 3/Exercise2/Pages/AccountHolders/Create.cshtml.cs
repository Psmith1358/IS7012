using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exercise2.Data;
using Exercise2.Models;

namespace Exercise2.Pages_AccountHolders
{
    public class CreateModel : PageModel
    {
        private readonly Exercise2.Data.Exercise2Context _context;

        public CreateModel(Exercise2.Data.Exercise2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AccountHolder.Add(AccountHolder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
