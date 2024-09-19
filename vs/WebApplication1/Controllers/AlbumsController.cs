using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : Controller
    {
        public AlbumsController(DbContextClass dbContext, IAlbumRepository albumRepository) 
        {
            DbContext = dbContext;
            AlbumRepository = albumRepository;
        }

        public DbContextClass DbContext { get; }
        public IAlbumRepository AlbumRepository { get; }

        [HttpGet("GetAlbums")]
        public IEnumerable<Albums> GetAllAlbums()
        {
           return AlbumRepository.GetAlbums();
        }

        [HttpGet("GetAlbums/{id}")]
        public Albums GetOneAlbum(int id)
        {
            return AlbumRepository.GetOneAlbum(id);
        }

        [HttpPut("EditArtist/{id}")]
        public bool EditArtist(int id, Albums albums)
        {
            return AlbumRepository.EditAlbum(id, albums);
        }

        [HttpPost("AddNewAlbum")]
        public bool AddNewAlbum(Albums albums) 
        {
           return AlbumRepository.AddNewAlbum(albums);
        }

        [HttpDelete("DeleteAlbum/{id}")]
        public bool DeleteAlbum(int id) 
        {
            return AlbumRepository.DeleteAlbum(id);
        }
       
    }
}
