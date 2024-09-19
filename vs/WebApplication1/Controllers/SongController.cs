using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        

        public SongController(DbContextClass dbContext, ISongRepository Repository)
        {
            DbContext = dbContext;
            this.Repository = Repository;
        }

        public DbContextClass DbContext { get; }
        public ISongRepository Repository { get; }

        [HttpGet("GetSong")]
        public IEnumerable<Song> GetSongs()
        {
            return Repository.GetAllSongs();
        }

        [HttpGet("GetSong/{id}")]
        public Song GetSong(int id)
        {
            return Repository.GetSongById(id);
        }

        [HttpPost("AddNewSong")]
        public bool UpdateSong(Song song)
        {
            return Repository.AddNewSong(song);
        }

        [HttpDelete("DeleteSong/{id}")]
        public bool DeleteSong(int id)
        {
            return Repository.DeleteSong(id);
        }

        [HttpPut("EditSong/{id}")]
        public bool EditSong(int id,Song song)
        {
            return Repository.EditSong(id, song);
        }

        [HttpGet("GetSongByTitle/{title}")]
        public IEnumerable<Song> SongByTitle(string title)
        {
            return Repository.GetSongByTitle(title);
        }

    }
}
