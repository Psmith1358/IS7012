using Exercise2.Data;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exercise2.Pages_Candidates;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Candidate Candidate { get; set; } = default!;

    public IActionResult OnGet()
    {
        LoadDropdowns();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            LoadDropdowns();
            return Page();
        }

        _context.Candidates.Add(Candidate);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    private void LoadDropdowns()
    {
        ViewData["JobTitleId"] = new SelectList(
            _context.JobTitles,
            "Id",
            "TitleName");

        ViewData["CompanyId"] = new SelectList(
            _context.Companies,
            "Id",
            "CompanyName");

        ViewData["IndustryId"] = new SelectList(
            _context.Industries,
            "Id",
            "IndustryName");
    }
}