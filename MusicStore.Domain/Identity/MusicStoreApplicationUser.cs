using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MusicStore.Domain.Domain;


namespace MusicStore.Domain.Identity
{
    public class MusicStoreApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }

        // Relationships to shopping cart and tickets
        public ShoppingCart? UserCart { get; set; }
        public virtual ICollection<TicketInShoppingCart>? CartItems { get; set; } // Tracks in the user's cart

        // User's playlists (new addition for the current version)
        public virtual ICollection<UserPlaylist>? MyPlaylists { get; set; }

        // Tracks the user has bought or listened to (optional)
        public virtual ICollection<Ticket>? PurchasedTracks { get; set; }
    }
}
