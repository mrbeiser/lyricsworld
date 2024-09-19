using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ConnectionController : Controller
    {
        public DbContextClass DbContext { get; }
        public IConnectRepository Repository { get; }
        public ConnectionController(DbContextClass dbContext, IConnectRepository repository)
        {
            DbContext = dbContext;
            Repository = repository;
        }
        [HttpGet("GetAll")]
        public IEnumerable<ArtistAlbumSong> GetAll()
        {
            return Repository.GetAll();
        }
    }
}
