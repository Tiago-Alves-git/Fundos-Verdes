using MeuProjeto.Models;
using MeuProjeto.Dto;

namespace MeuProjeto.Repository
{
    public class Seeder
    {
        public static void SeedUserAdmin(IMeuProjetoContext _context)
        {
            try
            {
                var usersCount = _context.Users.Where(u => u.UserType == "admin").Count();
                if (usersCount == 0)
                {
                    _context.Users.Add(new User { Name = "admin", Email = "admin@admin.com", Password = "admin", UserType = "admin" });
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
        }
    }
}