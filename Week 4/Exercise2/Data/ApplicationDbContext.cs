using Exercise2.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise2.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
    public DbSet<Industry> Industries { get; set; }
}