using System.ComponentModel.DataAnnotations.Schema;
namespace Exercise2.Models;

public class BankAccount
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
   [Column(TypeName = "decimal(18,2)")]
    public decimal CurrentBalance { get; set; }
    public string AccountName { get; set; }
    public string AccountType { get; set; }
    public DateTime DateOpened { get; set; }

    public AccountHolder AccountHolder { get; set; }
    public int AccountHolderId { get; set; }
}