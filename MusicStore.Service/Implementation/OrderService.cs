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

        public Order GetOrderDetails(Guid orderId)
        {
            return orderRepository.GetOrderDetails(orderId);
        }

        public Order CreateOrder(string userId, ICollection<Ticket> tickets)
        {
            // Optionally, check if the user exists and handle errors.
            var user = userRepository.Get(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found.");
            }

            // Create the order
            var order = orderRepository.CreateOrder(userId, tickets);

            // After order creation, tracks are added to the user's playlist.
            AddTracksToPlaylist(userId, tickets);

            return order;
        }

        public void AddTracksToPlaylist(string userId, ICollection<Ticket> tickets)
        {
            orderRepository.AddTracksToPlaylist(userId, tickets);
        }
    }
}
