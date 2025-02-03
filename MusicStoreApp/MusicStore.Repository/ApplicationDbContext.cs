using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Domain.Identity;
using NuGet.DependencyResolver;

namespace MusicStoreApplication.Repository
{
    public class ApplicationDbContext : IdentityDbContext<MusicStoreApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
 
        public DbSet<Album> Albums { get; set; }
       
        public DbSet<ShoppingCartItem> CartItems { get; set; }
       
        public DbSet<BoughtItem> BoughtItems { get; set; }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserPlaylist> UserPlaylists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var artistIds = Enumerable.Range(1, 5).Select(_ => Guid.NewGuid()).ToArray();
            var albumIds = Enumerable.Range(1, 10).Select(_ => Guid.NewGuid()).ToArray();


            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.HasMany(a => a.Albums)
                      .WithOne(al => al.Artist)
                      .HasForeignKey(al => al.ArtistId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Artist deletes Albums

                // Seed data for Artist
                entity.HasData(
                    new Artist { Id = artistIds[0], Name = "Pink Floyd", Bio = "A legendary rock band." },
                    new Artist { Id = artistIds[1], Name = "The Beatles", Bio = "One of the most influential rock bands." },
                    new Artist { Id = artistIds[2], Name = "Led Zeppelin", Bio = "A rock band known for its heavy sound." },
                    new Artist { Id = artistIds[3], Name = "Queen", Bio = "A rock band known for its eclectic musical style." },
                    new Artist { Id = artistIds[4], Name = "Nirvana", Bio = "A grunge band that shaped the 90s music scene." }
                );
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(al => al.Id);

                entity.HasOne(al => al.Artist)
                      .WithMany(a => a.Albums)
                      .HasForeignKey(al => al.ArtistId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Artist deletes Albums

                entity.HasMany(al => al.Tracks)
                      .WithOne(tr => tr.Album)
                      .HasForeignKey(tr => tr.AlbumId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Album deletes Tracks

                // Seed data for Album (linked to the Artist)
                entity.HasData(
                    new Album { Id = albumIds[0], Title = "The Dark Side of the Moon", ReleaseDate = new DateTime(1973, 3, 1), ArtistId = artistIds[0] },
                    new Album { Id = albumIds[1], Title = "Wish You Were Here", ReleaseDate = new DateTime(1975, 9, 12), ArtistId = artistIds[0] },
                    new Album { Id = albumIds[2], Title = "Abbey Road", ReleaseDate = new DateTime(1969, 9, 26), ArtistId = artistIds[1] },
                    new Album { Id = albumIds[3], Title = "Let It Be", ReleaseDate = new DateTime(1970, 5, 8), ArtistId = artistIds[1] },
                    new Album { Id = albumIds[4], Title = "Led Zeppelin IV", ReleaseDate = new DateTime(1971, 11, 8), ArtistId = artistIds[2] },
                    new Album { Id = albumIds[5], Title = "Houses of the Holy", ReleaseDate = new DateTime(1973, 3, 28), ArtistId = artistIds[2] },
                    new Album { Id = albumIds[6], Title = "A Night at the Opera", ReleaseDate = new DateTime(1975, 11, 21), ArtistId = artistIds[3] },
                    new Album { Id = albumIds[7], Title = "The Works", ReleaseDate = new DateTime(1984, 2, 27), ArtistId = artistIds[3] },
                    new Album { Id = albumIds[8], Title = "Nevermind", ReleaseDate = new DateTime(1991, 9, 24), ArtistId = artistIds[4] },
                    new Album { Id = albumIds[9], Title = "In Utero", ReleaseDate = new DateTime(1993, 9, 21), ArtistId = artistIds[4] }
                );
            }); 

            // Order Configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(o => o.Owner)
                    .WithMany()
                    .HasForeignKey(o => o.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(o => o.BoughtItems)
                    .WithOne(t => t.Order)
                    .HasForeignKey(t => t.OrderId);
            });

            // ShoppingCart Configuration
            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(sc => sc.Id);

                entity.HasOne(sc => sc.Owner)
                    .WithMany()
                    .HasForeignKey(sc => sc.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(sc => sc.Items)
                    .WithOne(tisc => tisc.shoppingCart)
                    .HasForeignKey(tisc => tisc.ShoppingCartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Title)
                     .IsRequired()
                     .HasMaxLength(255);
                
                
                entity.HasOne(t => t.Album)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.AlbumId)
                .OnDelete(DeleteBehavior.Cascade); // Tracks are deleted when their Album is deleted

                entity.HasOne(t => t.Artist) // New relationship configuration
                     .WithMany(a => a.Tracks)
                     .HasForeignKey(t => t.ArtistId)
                     .OnDelete(DeleteBehavior.Restrict); // Tracks are deleted when their Artist is deleted

                entity.HasData(
        // The Dark Side of the Moon
        new Track { Id = Guid.NewGuid(), Title = "Speak to Me", Duration = TimeSpan.FromMinutes(1), AlbumId = albumIds[0], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "Breathe", Duration = TimeSpan.FromMinutes(2), AlbumId = albumIds[0], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "On the Run", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[0], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "Time", Duration = TimeSpan.FromMinutes(6), AlbumId = albumIds[0], ArtistId = artistIds[0] },

        // Wish You Were Here
        new Track { Id = Guid.NewGuid(), Title = "Shine On You Crazy Diamond (Part I-V)", Duration = TimeSpan.FromMinutes(13), AlbumId = albumIds[1], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "Welcome to the Machine", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[1], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "Have a Cigar", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[1], ArtistId = artistIds[0] },
        new Track { Id = Guid.NewGuid(), Title = "Wish You Were Here", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[1], ArtistId = artistIds[0] },

        // Abbey Road
        new Track { Id = Guid.NewGuid(), Title = "Come Together", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[2], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "Something", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "Octopus's Garden", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "Here Comes the Sun", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1] },

        // Let It Be
        new Track { Id = Guid.NewGuid(), Title = "Let It Be", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[3], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "Across the Universe", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "The Long and Winding Road", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1] },
        new Track { Id = Guid.NewGuid(), Title = "Get Back", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1] },

        // Led Zeppelin IV
        new Track { Id = Guid.NewGuid(), Title = "Black Dog", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[4], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "Rock and Roll", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[4], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "Stairway to Heaven", Duration = TimeSpan.FromMinutes(8), AlbumId = albumIds[4], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "Going to California", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[4], ArtistId = artistIds[2] },

        // Houses of the Holy
        new Track { Id = Guid.NewGuid(), Title = "The Song Remains the Same", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[5], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "The Rain Song", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[5], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "Over the Hills and Far Away", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[5], ArtistId = artistIds[2] },
        new Track { Id = Guid.NewGuid(), Title = "No Quarter", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[5], ArtistId = artistIds[2] },

        // A Night at the Opera
        new Track { Id = Guid.NewGuid(), Title = "Death on Two Legs", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "You're My Best Friend", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "Love of My Life", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "Bohemian Rhapsody", Duration = TimeSpan.FromMinutes(6), AlbumId = albumIds[6], ArtistId = artistIds[3] },

        // The Works
        new Track { Id = Guid.NewGuid(), Title = "Radio Ga Ga", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[7], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "Tear It Up", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[7], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "It's a Hard Life", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[7], ArtistId = artistIds[3] },
        new Track { Id = Guid.NewGuid(), Title = "I Want to Break Free", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[7], ArtistId = artistIds[3] },

        // Nevermind
        new Track { Id = Guid.NewGuid(), Title = "Smells Like Teen Spirit", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[8], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "In Bloom", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[8], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "Come as You Are", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[8], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "Lithium", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[8], ArtistId = artistIds[4] },

        // In Utero
        new Track { Id = Guid.NewGuid(), Title = "Serve the Servants", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[9], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "Heart-Shaped Box", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[9], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "Rape Me", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[9], ArtistId = artistIds[4] },
        new Track { Id = Guid.NewGuid(), Title = "Pennyroyal Tea", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[9], ArtistId = artistIds[4] }
    );
            });

            // UserPlaylist Configuration
            modelBuilder.Entity<UserPlaylist>(entity =>
            {
                entity.HasKey(up => up.Id);

                entity.Property(up => up.Name)
                    .HasMaxLength(255);

                entity.HasOne(up => up.User)
                    .WithMany()
                    .HasForeignKey(up => up.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(up => up.Tracks)
                    .WithMany(t => t.Playlists);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
