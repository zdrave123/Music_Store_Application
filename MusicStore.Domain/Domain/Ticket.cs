using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Ticket : BaseEntity
    {
        public Guid TrackId { get; set; }
        public Track? Track { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }

        public ICollection<TicketInShoppingCart> ProductsInShoppingCart { get; set; } = new List<TicketInShoppingCart>();
     
    }
}
