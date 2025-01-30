using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IUserRepository userRepository;

        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository)
        {
            this.orderRepository = orderRepository;
            this.userRepository = userRepository;
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }

        public Order GetOrderDetails(BaseEntity orderId)
        {
            return orderRepository.GetOrderDetails(orderId);
        }

        public Order CreateOrder(string userId, ICollection<BoughtItem> boughtItems)
        {
           
            var user = userRepository.Get(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found.");
            }

            
            return orderRepository.CreateOrder(userId, boughtItems);
        }

        public Order DeleteOrder(Guid id)
        {
            return orderRepository.DeleteOrder(id);
        }

        public void DeleteAllOrders()
        {
            orderRepository.DeleteAllOrders();
        }
    }
}
