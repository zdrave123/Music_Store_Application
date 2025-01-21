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
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
 
        public DbSet<Album> Albums { get; set; }
       

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserPlaylist> UserPlaylists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var artistId = Guid.NewGuid(); // Single GUID for seeding Artist and Album relationship
            var albumId = Guid.NewGuid();
            var TrackId = Guid.NewGuid();

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.HasMany(a => a.Albums)
                      .WithOne(al => al.Artist)
                      .HasForeignKey(al => al.ArtistId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Artist deletes Albums

                // Seed data for Artist
                entity.HasData(new Artist
                {
                    Id = artistId,
                    Name = "Pink Floyd",
                    Bio = "A legendary rock band."
                });
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
                entity.HasData(new Album
                {
                    Id = albumId,
                    Title = "The Dark Side of the Moon",
                    ReleaseDate = new DateTime(1973, 3, 1),
                    ArtistId = artistId // Reference the same ID as the Artist
                });
            }); 

            // Order Configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(o => o.Owner)
                    .WithMany()
                    .HasForeignKey(o => o.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(o => o.Tickets)
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

                entity.HasMany(sc => sc.TicketInShoppingCarts)
                    .WithOne(tisc => tisc.ShoppingCart)
                    .HasForeignKey(tisc => tisc.ShoppingCartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Ticket Configuration
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Price)
                    .IsRequired();

                entity.Property(t => t.Rating)
                    .IsRequired()
                    .HasDefaultValue(0);

                entity.HasOne(t => t.Track)
                    .WithMany()
                    .HasForeignKey(t => t.TrackId);

                entity.HasMany(t => t.ProductsInShoppingCart)
                    .WithOne(tisc => tisc.Ticket)
                    .HasForeignKey(tisc => tisc.TicketId);
            });

            // TicketInShoppingCart Configuration
            modelBuilder.Entity<TicketInShoppingCart>(entity =>
            {
                entity.HasKey(tisc => tisc.Id);

                entity.HasOne(tisc => tisc.Ticket)
                    .WithMany(t => t.ProductsInShoppingCart)
                    .HasForeignKey(tisc => tisc.TicketId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(tisc => tisc.ShoppingCart)
                    .WithMany(sc => sc.TicketInShoppingCarts)
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

                entity.HasData(new Track
                {
                    Id = TrackId,
                    Title = "Stoned",
                    Duration = TimeSpan.FromMinutes(3),
                    AlbumId = albumId,
                    ArtistId = artistId
                });;
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
