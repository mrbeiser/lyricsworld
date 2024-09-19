using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly DbContextClass _context;

        public ArtistsController(DbContextClass context, IArtistRepository repository)
        {
            _context = context;
            Repository = repository;
        }

        public IArtistRepository Repository { get; }

        [HttpGet("GetArtist")]
        public IEnumerable<Artist> GetAllArtists() 
        {
            return Repository.GetAllArtists();
        }

        [HttpGet("GetArtist/{id}")]
        public Artist GetOneArtist(int id) 
        {
            return Repository.GetOneArtist(id);
        }

        [HttpPost("AddNewArtist")]
        public bool AddNewArtist(Artist artist)
        {
            return Repository.AddNewArtist(artist);
        }

        [HttpDelete("DeleteOneArtist/{id}")]
        public bool DeleteArtist(int id) 
        { 
            return Repository.DeleteArtist(id);
        }

        [HttpPut("EditArtist/{id}")]
        public bool EditArtist(int id, Artist artist) 
        {
            return Repository.EditArtist(id, artist);
        }
    }
}
