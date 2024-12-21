using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface ITicketService
    {
        void AddTicketToCart(string userId, Guid ticketId);
        void RemoveTicketFromCart(string userId, Guid ticketId);
        IEnumerable<Ticket> GetTicketsInCart(string userId);
    }
}
