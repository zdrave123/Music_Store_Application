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

    }
}
