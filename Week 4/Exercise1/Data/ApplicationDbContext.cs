using Exercise1.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise1.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<AccountHolder> AccountHolders { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
}