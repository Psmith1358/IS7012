using System.ComponentModel.DataAnnotations;

namespace Exercise2.Models;

public class JobTitle
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Job Title")]
    public string TitleName { get; set; } = string.Empty;

    [Required]
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Display(Name = "Company")]
    public int CompanyId { get; set; }

    public Company? Company { get; set; }

    public ICollection<Candidate> Candidates { get; set; }
        = new List<Candidate>();
}