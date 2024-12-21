using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IShoppingCartRepository
    {
        ShoppingCart GetCartForUser(string userId);
        void AddTicketToCart(string userId, Ticket ticket);
        void RemoveTicketFromCart(string userId, Guid ticketId);
        void ClearCart(string userId);
        void SaveCart(ShoppingCart shoppingCart);

        void AddTrackToCart(Guid trackId, string userId);
    }
}
