/*using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class TicketService : ITicketService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IRepository<Ticket> _ticketRepository;

        public TicketService(IShoppingCartRepository shoppingCartRepository, IRepository<Ticket> ticketRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _ticketRepository = ticketRepository;
        }

        public void AddTicketToCart(string userId, Guid ticketId)
        {
            var ticket = _ticketRepository.Get(ticketId);
            if (ticket != null)
            {
                _shoppingCartRepository.AddTicketToCart(userId, ticket);
            }
            else
            {
                throw new Exception("Ticket not found");
            }
        }

        public void RemoveTicketFromCart(string userId, Guid ticketId)
        {
            _shoppingCartRepository.RemoveTicketFromCart(userId, ticketId);
        }

        public IEnumerable<Ticket> GetTicketsInCart(string userId)
        {
            var cart = _shoppingCartRepository.GetCartForUser(userId);
            return cart.TicketInShoppingCarts.Select(ticketInCart => ticketInCart.Ticket);
        }
    }
}
*/