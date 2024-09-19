using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string username {  get; set; }
        [Required]
        public string password { get; set; }

    }
}
