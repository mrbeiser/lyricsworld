using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace WebApplication1.Models
{
    [Table("Albums")]
    public class Albums
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        public string AlbumTitle { get;set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public string AlbumCover { get;set;}
        [Required]
        public string AlbumType { get; set; }

        //public List<ConnectDBtable> connectDBtable { get; set; } = new List<ConnectDBtable>();
        public Albums() 
        { 
        }
            
        public Albums(int AlbumID, string AlbumTitle,DateTime DateAdded, string AlbumCover, string AlbumType)
        {
            AlbumID = this.AlbumID;
            AlbumTitle = this.AlbumTitle;
            DateAdded = this.DateAdded;
            AlbumCover = this.AlbumCover;
            AlbumType = this.AlbumType;
        }
    }
}
