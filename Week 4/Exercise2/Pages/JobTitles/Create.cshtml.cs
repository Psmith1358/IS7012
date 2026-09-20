using Exercise2.Data;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exercise2.Pages_JobTitles;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public JobTitle JobTitle { get; set; } = default!;

    public IActionResult OnGet()
    {
        LoadCompanies();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            LoadCompanies();
            return Page();
        }

        _context.JobTitles.Add(JobTitle);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    private void LoadCompanies()
    {
        ViewData["CompanyId"] = new SelectList(
            _context.Companies,
            "Id",
            "CompanyName");
    }
}