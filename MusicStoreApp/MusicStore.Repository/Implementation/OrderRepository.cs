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
                .Include(o => o.BoughtItems)
                .Include(o => o.Owner)     
                .ToList();
        }

        public Order GetOrderDetails(BaseEntity id)
        {
            return context.Orders
                .Include(o => o.BoughtItems)
                .Include(o => o.Owner)
                .FirstOrDefault(o => o.Id == id.Id);
        }

        public Order CreateOrder(string userId, ICollection<BoughtItem> boughtItems)
        {
            var order = new Order
            {
                OwnerId = userId,
                BoughtItems = boughtItems,
                CreatedAt = DateTime.Now,
            };

            context.Orders.Add(order);
            context.SaveChanges();

            return order;
        }

        public Order DeleteOrder(Guid id)
        {
            var order = context.Orders.FirstOrDefault(o => o.Id == id);

            if (order != null)
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }

            return order;
        }

        public void DeleteAllOrders()
        {
            context.Orders.RemoveRange(context.Orders.ToList());
            context.SaveChanges();
        }
    }

}
