﻿using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCart GetCartForUser(string userId);
        void AddTicketToCart(string userId, Ticket ticket);
        void RemoveTicketFromCart(string userId, Guid ticketId);
        void ClearCart(string userId);
    }
}
