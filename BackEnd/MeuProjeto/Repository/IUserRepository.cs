using MeuProjeto.Models;
using MeuProjeto.Dto;

namespace MeuProjeto.Repository
{
    public interface IUserRepository
    {
        UserDto GetUserById(int userId);
        UserDto Add(UserDtoInsert user);
        UserDto Login(LoginDto login);
        UserDto GetUserByEmail(string userEmail);
        IEnumerable<UserDto> GetUsers();
    }

}