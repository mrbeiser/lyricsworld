using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists();
        Artist GetOneArtist(int id);
        bool AddNewArtist(Artist artist);
        bool DeleteArtist(int id);
        bool EditArtist(int id, Artist artist);
    }
}
