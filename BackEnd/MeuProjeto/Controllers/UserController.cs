using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;
using MeuProjeto.Repository;
using MeuProjeto.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using System.Security.Claims;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("signup")]

    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize(Policy = "Admin")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _repository.GetUsers();
                return Ok(users);
            }
            catch
            {
                // Tratar outros possíveis erros
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserDtoInsert user)
        {
            try
            {
                var newUser = _repository.Add(user);

                // Monta o DTO de resposta
                var userDto = new UserDto
                {
                    UserId = newUser.UserId,
                    Name = newUser.Name,
                    Email = newUser.Email,
                    UserType = newUser.UserType
                };
                return Created("/user", userDto);
            }
            catch (EmailAlreadyExistsException)
            {
                return Conflict(new { message = "User email already exists" });
            }
        }

        [HttpPost("signup/google")]
        public IActionResult SignUpWithGoogle(string returnUrl = "/")
        {
            throw new NotImplementedException();
        }
    }
}