using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.AspNetCore.Razor.Language;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SongRepository : ISongRepository
    {
        

        public SongRepository(DbContextClass dbContext)
        {
            DbContext = dbContext;
        }
        public DbContextClass DbContext { get; }
        public IEnumerable<Song> GetAllSongs()
        {
            IEnumerable<Song> songs = DbContext.Songs.ToList();
            return songs;
        }

        public bool EditSong(int Id, Song song)
        {
            if (song.SongID!= Id)
            {
                return false;
            }
            if (DbContext.Songs.Update(song) != null)
            {
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Song GetSongById(int id)
        {
            return DbContext.Songs.Find(id);
        }

        public bool DeleteSong(int id)
        {
            
            var song = GetSongById(id);
            if (song == null) return false;
            if (DbContext.Remove(song) != null)
            {
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddNewSong(Song piosenka)
        {
            if (piosenka.SongID == 0)
            {
                var result = DbContext.Add(piosenka);
                if (result != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Song> GetSongByTitle(string title)
        {
            string lowerTitle = title.ToLower();
            return DbContext.Songs.Where(song => EF.Functions.Like(song.SongTitle, "%"+lowerTitle+"%")).ToList();
        }
    }
}