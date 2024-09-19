using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public class ConnectRepository : IConnectRepository
    {
        

        public ConnectRepository(DbContextClass dbContext)
        {
           this.dbContext = dbContext;
        }
        public DbContextClass dbContext { get; }
        
        public IEnumerable<ArtistAlbumSong> GetAll()
        {
            var query = (from con in dbContext.ConnectDb
                join al in dbContext.Albums on con.IDalbum equals al.AlbumID
                         join sng in dbContext.Songs on con.IDsong equals sng.SongID
                join art in dbContext.Artist on con.IDartist equals art.Id
                select new ArtistAlbumSong()
                {
                    ConnID = con.ConnID,
                    album = al,
                    AlbumID = al.AlbumID,
                    song = sng,
                    SongID = sng.SongID,
                    artist= art,
                    ArtistID = art.Id
                });
          //  var query = dbContext.ConnectDb.Include(s => s.song).Include(al => al.albums).Include(ar => ar.artist).ToList();
            return query;
        }
    }
}
//SELECT AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID FROM dbo.Albums JOIN dbo.ConnectDB ON dbo.Albums.AlbumID=dbo.ConnectDB.IDalbum JOIN dbo.Songs ON 
//dbo.Songs.SongID=dbo.ConnectDB.IDsong JOIN dbo.Artists ON dbo.Artists.ArtistID=dbo.ConnectDB.IDartist