using System.ComponentModel.DataAnnotations;

namespace Exercise2.Models;

public class Industry
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Industry Name")]
    public string IndustryName { get; set; } = string.Empty;

    public ICollection<Company> Companies { get; set; }
        = new List<Company>();

    public ICollection<Candidate> Candidates { get; set; }
        = new List<Candidate>();
}