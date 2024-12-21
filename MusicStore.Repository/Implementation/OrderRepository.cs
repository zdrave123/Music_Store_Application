using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStoreApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Order> GetAllOrders()
        {
            return context.Orders
                .Include(o => o.Tickets)  // Include tickets in the order
                .ThenInclude(t => t.Track)  // Include track details for each ticket
                .Include(o => o.Owner)  // Include user details for the order
                .ToList();
        }

        public Order GetOrderDetails(Guid id)
        {
            return context.Orders
                .Include(o => o.Tickets)
                .ThenInclude(t => t.Track)
                .Include(o => o.Owner)
                .FirstOrDefault(o => o.Id == id);
        }

        public Order CreateOrder(string userId, ICollection<Ticket> tickets)
        {
            var order = new Order
            {
                OwnerId = userId,
                Tickets = tickets,
                // Optionally, you can also handle timestamps or other order-related properties here.
            };

            context.Orders.Add(order);
            context.SaveChanges();

            // Add purchased tracks to the user's playlist
            AddTracksToPlaylist(userId, tickets);

            return order;
        }

        public void AddTracksToPlaylist(string userId, ICollection<Ticket> tickets)
        {
            // Check if the user has a playlist
            var userPlaylist = context.UserPlaylists
                .FirstOrDefault(p => p.UserId == userId);

            if (userPlaylist != null)
            {
                // Add the purchased tracks to the playlist
                foreach (var ticket in tickets)
                {
                    if (!userPlaylist.Tracks.Contains(ticket.Track))
                    {
                        userPlaylist.Tracks.Add(ticket.Track);
                    }
                }
            }
            else
            {
                // If the user doesn't have a playlist, create one and add tracks
                var newPlaylist = new UserPlaylist
                {
                    UserId = userId,
                    Tracks = tickets.Select(t => t.Track).ToList()
                };

                context.UserPlaylists.Add(newPlaylist);
            }

            context.SaveChanges();
        }
    }

}
