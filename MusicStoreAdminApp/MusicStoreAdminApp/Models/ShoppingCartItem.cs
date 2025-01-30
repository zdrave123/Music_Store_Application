using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdminApp.Models
{
    public class ShoppingCartItem : BaseEntity
    {
        public Guid ProductId { get; set; } // ID of Track or Album
        public string ProductName { get; set; }
        public string ProductType { get; set; } // "Track" or "Album"

        public ShoppingCart shoppingCart { get; set; }

        public Guid ShoppingCartId { get; set; }
        public int Price { get; set; }


    }
}
