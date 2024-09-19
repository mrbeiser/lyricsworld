using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public interface IConnectRepository
    {
        IEnumerable<ArtistAlbumSong> GetAll();
    }
}
