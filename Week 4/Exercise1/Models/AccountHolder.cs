using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise1.Models;

public class AccountHolder
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Display(Name = "Email Address")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Home Address")]
    public string Address { get; set; } = string.Empty;

    [NotMapped]
    [Display(Name = "Account Holder")]
    public string FullName => $"{FirstName} {LastName}";

    public ICollection<BankAccount> BankAccounts { get; set; }
        = new List<BankAccount>();
}