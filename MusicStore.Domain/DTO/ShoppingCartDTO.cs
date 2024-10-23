﻿using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.DTO
{
    public class ShoppingCartDTO
    {
        public List<TicketInShoppingCart>? AllProducts { get; set; }
        public double TotalPrice { get; set; }
    }
}
