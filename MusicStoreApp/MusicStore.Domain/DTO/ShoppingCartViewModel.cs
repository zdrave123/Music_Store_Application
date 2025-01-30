using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.DTO
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItem> CartItems { get; set; } = new List<ShoppingCartItem>();
        public List<BoughtItem> BoughtItems { get; set; } = new List<BoughtItem>();

        public int TotalPrice { get; set; }
    }
}
