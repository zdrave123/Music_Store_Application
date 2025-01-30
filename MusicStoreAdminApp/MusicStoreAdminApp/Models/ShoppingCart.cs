using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdminApp.Models
{
    public class ShoppingCart : BaseEntity
    {
        public string? OwnerId { get; set; }
        public MusicStoreApplicationUser? Owner { get; set; }
        public ICollection<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
    }
}
