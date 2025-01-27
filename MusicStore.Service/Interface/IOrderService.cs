using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(Guid orderId);
        Order CreateOrder(string userId, ICollection<BoughtItem> boughtItems);
        Order DeleteOrder(Guid id);
        void DeleteAllOrders();
    }
}
