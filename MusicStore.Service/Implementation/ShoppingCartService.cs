using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public ShoppingCart GetCartForUser(string userId)
        {
            return shoppingCartRepository.GetCartForUser(userId);
        }

        public void AddTicketToCart(string userId, Ticket ticket)
        {
            shoppingCartRepository.AddTicketToCart(userId, ticket);
        }

        public void RemoveTicketFromCart(string userId, Guid ticketId)
        {
            shoppingCartRepository.RemoveTicketFromCart(userId, ticketId);
        }

        public void ClearCart(string userId)
        {
            shoppingCartRepository.ClearCart(userId);
        }
    }
    }

