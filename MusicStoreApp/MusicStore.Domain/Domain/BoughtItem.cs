using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class BoughtItem : BaseEntity
    {
        public Guid ProductId { get; set; } // ID of Track or Album
        public string ProductName { get; set; }
        public string ProductType { get; set; } // "Track" or "Album"

        public int Price { get; set; }

        public Guid? OrderId { get; set; } 
        public Order Order { get; set; }

    }
}
