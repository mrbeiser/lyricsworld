using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AlbumRepository : IAlbumRepository
    {
        public AlbumRepository(DbContextClass dbContext)
        {
            DbContext = dbContext;
        }
        public AlbumRepository() { }
        public DbContextClass DbContext;

        public IEnumerable<Albums> GetAlbums()
        {
            IEnumerable<Albums> albums = DbContext.Albums.ToList();
            return albums;
        }

        public Albums GetOneAlbum(int id)
        {
            var album = DbContext.Albums.Find(id);
            return album;
        }

        public bool EditAlbum (int id, Albums albums)
        {
            if (albums.AlbumID != id)
            {
                return false;
            }
            if (DbContext.Albums.Update(albums)!= null)
            {
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddNewAlbum(Albums album)
        {
            var result = DbContext.Add(album);
            DbContext.SaveChanges();
            return result != null;
        }

        public bool DeleteAlbum(int id)
        {
            var album = GetOneAlbum(id);
            if (album != null)
            {
                if (DbContext.Remove(album) != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        
    }
}
