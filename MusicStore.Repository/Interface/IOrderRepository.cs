using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(Guid id);  // Get order by ID
        Order CreateOrder(string userId, ICollection<Ticket> tickets);  // Create a new order
        void AddTracksToPlaylist(string userId, ICollection<Ticket> tickets);  // Add purchased tracks to user's playlist
    }
}
