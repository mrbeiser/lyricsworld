using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTOs
{
    public class RegisterDTO
    {
        [Key]
        public string username { get; set; }
        [Microsoft.Build.Framework.Required]
        public string password { get; set; }
        [Microsoft.Build.Framework.Required]
        public string email { get; set; }
    }
}
