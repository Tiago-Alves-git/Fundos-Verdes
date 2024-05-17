using Microsoft.EntityFrameworkCore;
using MeuProjeto.Models;

namespace MeuProjeto.Repository
{
    public interface IMeuProjetoContext
    {
        public DbSet<User> Users { get; set; }
        public int SaveChanges();
    }
}
