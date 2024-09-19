using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("UserName")]
        public string username { get; set; }
        [Required]
        [Column("UserPassword")]
        public string password { get; set; }

        [Column("UserProfilePicture")]
        public string profilePicture { get; set; } =
            "https://th.bing.com/th/id/OIP.TmFdrhMS6gzhI-ACF3977wAAAA?rs=1&pid=ImgDetMain";

        [Column("UserLikes")] public int likes { get; set; } = 0;
        [Required]
        [Column("UserEmail")]
        public string email { get; set; }
        [Required]
        [Column("UserRole")]
        public char role{ get; set; }='U';

    }
}
