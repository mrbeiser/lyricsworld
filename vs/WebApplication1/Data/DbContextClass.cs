using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) 
        { 
            
        }

        public DbSet<Albums> Albums{ get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; } 
        public DbSet<ConnectDBtable> ConnectDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Albums>().HasMany(e => e.connectDBtable).WithOne(e => e.albums)
            //    .HasForeignKey(e => e.IDalbum).IsRequired();

            //modelBuilder.Entity<Artist>().HasMany(e => e.connectDBtable).WithOne(e => e.artist)
            //    .HasForeignKey(e => e.IDartist).IsRequired();

            //modelBuilder.Entity<Song>().HasMany(e => e.connectDBtable).WithOne(e => e.song)
            //    .HasForeignKey(e => e.IDsong).IsRequired();


        }
    }
    
}
