using Exercise2.Data;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Exercise2.Pages_Companies;

public class DetailsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DetailsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public Company Company { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var company = await _context.Companies
            .Include(company => company.Industry)
            .Include(company => company.Candidates)
                .ThenInclude(candidate => candidate.JobTitle)
            .FirstOrDefaultAsync(company => company.Id == id);

        if (company == null)
        {
            return NotFound();
        }

        Company = company;
        return Page();
    }
}