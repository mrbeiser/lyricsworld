namespace WebApplication1.Models
{
    public class AlbumSongArtist
    {
        public int ArtistID { get; set; }
        public int SongID { get; set; }
        public int AlbumID { get; set; }
        public Song Song { get; set; } = null;
        public Albums Album { get; set; } = null;
        public Artist Artist { get; set; } = null;

    }
}
