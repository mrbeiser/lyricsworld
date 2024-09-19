using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface ISongRepository
    {
        public IEnumerable<Song> GetAllSongs();
        public bool EditSong(int Id, Song song);
        public Song GetSongById(int SongID);
        public bool DeleteSong(int SongID);
        public bool AddNewSong(Song piosenka);

        public IEnumerable<Song> GetSongByTitle(string title);
    }
}
