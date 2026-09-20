using System.ComponentModel.DataAnnotations;

namespace Exercise2.Models;

public class Company
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Company Name")]
    public string CompanyName { get; set; } = string.Empty;

    [Required]
    [StringLength(500)]
    public string Location { get; set; } = string.Empty;

    [Display(Name = "Industry")]
    public int IndustryId { get; set; }

    public Industry? Industry { get; set; }

    public ICollection<JobTitle> JobTitles { get; set; }
        = new List<JobTitle>();

    public ICollection<Candidate> Candidates { get; set; }
        = new List<Candidate>();
}