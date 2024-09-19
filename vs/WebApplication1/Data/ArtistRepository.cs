using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ArtistRepository : IArtistRepository
    {
        public ArtistRepository(DbContextClass dbContextClass)
        {
            DbContextClass = dbContextClass;
        }

        public DbContextClass DbContextClass { get; }

        public IEnumerable<Artist> GetAllArtists()
        {
            var result = DbContextClass.Artist.ToArray();
            return result;
        }

        public Artist GetOneArtist(int id)
        {
            var result = DbContextClass.Artist.Find(id);
            return result;
        }

        public bool AddNewArtist(Artist artist)
        {
            if (artist.Id == 0)
            {
                var result = DbContextClass.Add(artist);
                if (result != null)
                {
                    DbContextClass.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteArtist(int id)
        {
            var artist = GetOneArtist(id);
            if (artist != null) 
            {
                if (DbContextClass.Remove(artist) != null)
                {
                    DbContextClass.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool EditArtist(int id, Artist artist)
        {
            if(artist.Id != id)
            {
                return false; 
            }

            if (DbContextClass.Artist.Update(artist) != null)
            {
                    DbContextClass.SaveChanges();
                    return true;
            }
            return false;
        }
    }
}
