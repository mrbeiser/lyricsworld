using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ArtistController : Controller
    {
        public ArtistController(IArtistRepository artistRepository, DbContextClass dbContextClass)
        {
            ArtistRepository = artistRepository;
            DbContextClass = dbContextClass;
        }

        public IArtistRepository ArtistRepository { get; }
        public DbContextClass DbContextClass { get; }

        public IActionResult ArtistList()
        {
            var result = ArtistRepository.GetAllArtists();
            return View(result);
        }
    }
}
