using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public interface IUserRepository
    {
        public ProfileDTO GetOneUser(string username);
        public bool Login(LoginDTO loginDTO);
        public bool Register(RegisterDTO user);
    }
}
