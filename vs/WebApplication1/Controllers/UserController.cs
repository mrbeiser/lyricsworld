using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;
using WebApplication1.TokenFolder;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController(DbContextClass dbContextClass, IUserRepository userRepository, JwtConfig jwtConfig)
        {
            DbContext = dbContextClass;
            UserRepository = userRepository;
            this.jwtConfig = jwtConfig;
        }
        private readonly JwtConfig jwtConfig;

        public DbContextClass DbContext { get; }
        public IUserRepository UserRepository { get; }

        

        [HttpPost("RegisterUser")]
        public IActionResult Register(RegisterDTO user)  
        {
            if (UserRepository.Register(user))
            {
                return Ok(new 
                {
                    message="User registered succesfully",
                    username=user.username
                });
            }
            return BadRequest(new {message = "Cannot register user", status=400});
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO loginDTO)
        {

            if (UserRepository.Login(loginDTO))
            {
                var jwt = jwtConfig.GenerateKey(loginDTO.username);
                string username = loginDTO.username;
                return Ok(new { jwt, username});
            } 
            return BadRequest(new {message="Username and/or password is wrong", status=HttpStatusCode.NotModified});
        }
        [Authorize]
        [HttpGet("GetUser/{username}")]
        public ProfileDTO GetOneUser(string username)
        {
            return UserRepository.GetOneUser(username);
        }
    }
}