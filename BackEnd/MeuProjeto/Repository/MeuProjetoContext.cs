using Microsoft.EntityFrameworkCore;
using MeuProjeto.Models;

namespace MeuProjeto.Repository;
public class MeuProjetoContext : DbContext, IMeuProjetoContext
{
    public DbSet<User> Users { get; set; }
    public MeuProjetoContext(DbContextOptions<MeuProjetoContext> options) : base(options)
    {
        Seeder.SeedUserAdmin(this);
    }
    public MeuProjetoContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure a connection string
        var connectionString = "Server=localhost;Database=model;User=SA;Password=SqlServer123!;TrustServerCertificate=True";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
