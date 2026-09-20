using System.ComponentModel.DataAnnotations;

namespace Exercise1.Models;

public class BankAccount
{
    public int Id { get; set; }

    [Display(Name = "Account Number")]
    public string AccountNumber { get; set; } = string.Empty;

    [Display(Name = "Current Balance")]
    [DataType(DataType.Currency)]
    public decimal CurrentBalance { get; set; }

    [Display(Name = "Account Name")]
    public string AccountName { get; set; } = string.Empty;

    [Display(Name = "Account Type")]
    public string AccountType { get; set; } = string.Empty;

    [Display(Name = "Date Opened")]
    [DataType(DataType.Date)]
    public DateTime DateOpened { get; set; }

    [Display(Name = "Account Holder")]
    public int AccountHolderId { get; set; }

    public AccountHolder? AccountHolder { get; set; }
}