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
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieves the shopping cart for a specific user
        public ShoppingCart GetCartForUser(string userId)
        {
            return _context.ShoppingCarts
                           .Include(cart => cart.TicketInShoppingCarts)
                           .ThenInclude(ticketInCart => ticketInCart.Ticket)
                           .FirstOrDefault(cart => cart.OwnerId == userId)
                           ?? new ShoppingCart { OwnerId = userId }; // Create new cart if none exists
        }

        // Adds a ticket to the user's shopping cart
        public void AddTicketToCart(string userId, Ticket ticket)
        {
            var cart = GetCartForUser(userId);
            var existingTicket = cart.TicketInShoppingCarts
                                      .FirstOrDefault(t => t.TicketId == ticket.Id);

            if (existingTicket == null)
            {
                // If ticket doesn't exist in the cart, add it
                cart.TicketInShoppingCarts.Add(new TicketInShoppingCart
                {
                    TicketId = ticket.Id,
                    Ticket = ticket
                });
            }

            SaveCart(cart);
        }

        // Removes a specific ticket from the user's shopping cart
        public void RemoveTicketFromCart(string userId, Guid ticketId)
        {
            var cart = GetCartForUser(userId);
            var ticketToRemove = cart.TicketInShoppingCarts
                                     .FirstOrDefault(t => t.TicketId == ticketId);

            if (ticketToRemove != null)
            {
                cart.TicketInShoppingCarts.Remove(ticketToRemove);
                SaveCart(cart);
            }
        }

        // Clears all items from the user's shopping cart
        public void ClearCart(string userId)
        {
            var cart = GetCartForUser(userId);
            cart.TicketInShoppingCarts.Clear();
            SaveCart(cart);
        }

        public void AddTrackToCart(Guid trackId, string userId)
        {
            // Find the user's shopping cart
            var shoppingCart = _context.ShoppingCarts
                .FirstOrDefault(sc => sc.OwnerId == userId);

            if (shoppingCart == null)
            {
                // If the user doesn't have a shopping cart, create a new one
                shoppingCart = new ShoppingCart
                {
                    OwnerId = userId,
                    TicketInShoppingCarts = new List<TicketInShoppingCart>()
                };

                _context.ShoppingCarts.Add(shoppingCart);
                _context.SaveChanges();  // Save the new shopping cart to the database
            }

            // Check if the track is already in the shopping cart
            var existingTicket = _context.Tickets
                .FirstOrDefault(t => t.TrackId == trackId);

            if (existingTicket != null)
            {
                // Create a new TicketInShoppingCart for this track
                var ticketInCart = new TicketInShoppingCart
                {
                    TicketId = existingTicket.Id,  // Assuming Ticket has an Id field
                    ShoppingCartId = shoppingCart.Id
                };

                _context.TicketInShoppingCarts.Add(ticketInCart);  // Add the ticket to the cart
                _context.SaveChanges();  // Save changes to the database
            }
            else
            {
                throw new Exception("Track not found");  // If the track doesn't exist, throw an exception
            }
    }

        // Saves or updates the cart in the database
        public void SaveCart(ShoppingCart shoppingCart)
        {
            if (_context.ShoppingCarts.Any(cart => cart.Id == shoppingCart.Id))
            {
                _context.ShoppingCarts.Update(shoppingCart);
            }
            else
            {
                _context.ShoppingCarts.Add(shoppingCart);
            }

            _context.SaveChanges();
        }
    }
}
