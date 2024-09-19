namespace WebApplication1.Models.DTOs
{
    public class ArtistAlbumSong
    {
        public int ConnID { get; set; }
        public Artist artist { get; set; }
        public int ArtistID { get; set; }
        public Song song { get; set; }
        public int SongID { get; set; }
        public Albums album { get; set; }
        public int AlbumID { get;set; }
    }
}
