using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Domain.Identity;

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
            base.OnModelCreating(modelBuilder);

            // Album -> Artist (Many-to-One)
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(ar => ar.Albums)
                .HasForeignKey("ArtistId")
                .OnDelete(DeleteBehavior.Cascade);

            // Album -> Track (One-to-Many)
            modelBuilder.Entity<Track>()
                .HasOne(t => t.Album)
                .WithMany(a => a.Tracks)
                .HasForeignKey("AlbumId")
                .OnDelete(DeleteBehavior.Cascade);

            // Track -> Artist (Many-to-Many)
            modelBuilder.Entity<Track>()
                .HasMany(t => t.Artists)
                .WithMany(a => a.Tracks) // Configure the skip navigation property
                .UsingEntity<Dictionary<string, object>>(
                    "TrackArtists", // Name of the join table
                    j => j
                        .HasOne<Artist>()
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Restrict), // Prevent cascading delete for Artists
                    j => j
                        .HasOne<Track>()
                        .WithMany()
                        .HasForeignKey("TracksId")
                        .OnDelete(DeleteBehavior.Restrict) // Prevent cascading delete for Tracks
                );

            // Track -> UserPlaylist (Many-to-Many)
            modelBuilder.Entity<Track>()
                .HasMany(t => t.Playlists)
                .WithMany(p => p.Tracks)
                .UsingEntity(j => j.ToTable("PlaylistTracks"));

            // Ticket -> Track (Many-to-One)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Track)
                .WithMany()
                .HasForeignKey(t => t.TrackId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ticket -> Order (Many-to-One)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Order)
                .WithMany(o => o.Tickets)
                .HasForeignKey(t => t.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // TicketInShoppingCart -> Ticket (Many-to-One)
            modelBuilder.Entity<TicketInShoppingCart>()
                .HasOne(tisc => tisc.Ticket)
                .WithMany(t => t.ProductsInShoppingCart)
                .HasForeignKey(tisc => tisc.TicketId)
                .OnDelete(DeleteBehavior.Cascade);

            // TicketInShoppingCart -> ShoppingCart (Many-to-One)
            modelBuilder.Entity<TicketInShoppingCart>()
                .HasOne(tisc => tisc.ShoppingCart)
                .WithMany(sc => sc.TicketInShoppingCarts)
                .HasForeignKey(tisc => tisc.ShoppingCartId)
                .OnDelete(DeleteBehavior.Cascade);

            // ShoppingCart -> User (One-to-Many)
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.Owner)
                .WithMany()
                .HasForeignKey(sc => sc.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserPlaylist -> User (Many-to-One)
            modelBuilder.Entity<UserPlaylist>()
                .HasOne(up => up.User)
                .WithMany()
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Order -> User (Many-to-One)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Owner)
                .WithMany()
                .HasForeignKey(o => o.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasData(new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Jimmy Hendrix",
                    Bio = "dobar muzi4ar"
                });
            });
        }

    }
}
