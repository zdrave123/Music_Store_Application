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
        Order GetOrderDetails(BaseEntity id); 
        Order CreateOrder(string userId, ICollection<BoughtItem> boughtItems);
        Order DeleteOrder(Guid id);
        void DeleteAllOrders();
    }
}
