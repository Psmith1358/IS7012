using Exercise2.Data;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Exercise2.Pages_Candidates;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Candidate Candidate { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var candidate = await _context.Candidates
            .Include(candidate => candidate.JobTitle)
            .Include(candidate => candidate.Company)
            .Include(candidate => candidate.Industry)
            .FirstOrDefaultAsync(candidate => candidate.Id == id);

        if (candidate == null)
        {
            return NotFound();
        }

        Candidate = candidate;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var candidate = await _context.Candidates.FindAsync(id);

        if (candidate != null)
        {
            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}