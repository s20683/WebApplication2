using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options) { }

        protected MainDbContext() { }

        public DbSet<Musican> Musican { get; set; }
        public DbSet<MusicanTrack> MusicanTrack { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Album>(e =>
            {
                e.HasKey(e => e.IdAlbum);

                e.Property(e => e.AlbumName).IsRequired().HasMaxLength(30);
                e.Property(e => e.PublishDate).IsRequired();
                e.Property(e => e.IdMusicLabel);

                e.HasData(
                    new Album
                    {
                        IdAlbum = 1,
                        AlbumName = "Album1",
                        PublishDate = DateTime.Parse("2022-05-30"),
                        IdMusicLabel = 1
                    },

                    new Album
                    {
                        IdAlbum = 2,
                        AlbumName = "Album2",
                        PublishDate = DateTime.Parse("2022-05-20"),
                        IdMusicLabel = 2
                    }
                    );

            });

            modelBuilder.Entity<Track>(e =>
            {
                e.HasKey(e => e.IdTrack);
                e.Property(e => e.TrackName).IsRequired().HasMaxLength(20);
                e.Property(e => e.Duration).IsRequired();
                e.Property(e => e.IdMusicAlbum).IsRequired();

                e.HasData(
                    new Track
                    {
                        IdTrack = 1,
                        TrackName = "Track1",
                        Duration = 2.3f,
                        IdMusicAlbum = 1
                    },
                     new Track
                     {
                         IdTrack = 2,
                         TrackName = "Track2",
                         Duration = 8.3f,
                         IdMusicAlbum = 2
                     }) ;
            });

            modelBuilder.Entity<Musican>(e =>
            {
                e.HasKey(e => e.IdMusican);
                e.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
                e.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                e.Property(e => e.NickName).IsRequired().HasMaxLength(20);

                e.HasData(
                    new Musican
                    {
                        IdMusican = 1,
                        FirstName = "Nicki",
                        LastName = "Minaj",
                        NickName = "Bomba"
                    },
                     new Musican
                     {
                         IdMusican = 2,
                         FirstName = "Krzysztof",
                         LastName = "Krawczyk"
                     }
                    );
            });


        }
    }
}
