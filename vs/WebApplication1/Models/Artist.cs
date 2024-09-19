using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Artists")]
    public class Artist
    {

        [Column("ArtistID")]
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("ArtistName")]
        public string Name { get; set; }
        [Column("ArtistDescription")]
        public string Description { get; set; }
        [Column("ArtistPhoto")]
        public string Photo {  get; set; }
        [Column("ArtistPopularity")]
        public int Popularity {  get; set; }
        //public List<ConnectDBtable> connectDBtable { get; set; } = new List<ConnectDBtable>();
    }
}
