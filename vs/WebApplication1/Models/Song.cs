using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        public string SongTitle { get; set; }
        [Required]
        public int SongDuration { get; set; }
        [Required]
        public string SongLyrics { get; set; }
        public string SongGenre { get; set; }
       //public List<ConnectDBtable> connectDBtable { get; set; } = new List<ConnectDBtable>();
    }

}
