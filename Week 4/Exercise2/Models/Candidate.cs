using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise2.Models;

public class Candidate
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Job Title")]
    public int JobTitleId { get; set; }

    [Display(Name = "Job Title")]
    public JobTitle? JobTitle { get; set; }

    [Display(Name = "Company")]
    public int CompanyId { get; set; }

    public Company? Company { get; set; }

    [Display(Name = "Industry")]
    public int IndustryId { get; set; }

    public Industry? Industry { get; set; }

    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";
}