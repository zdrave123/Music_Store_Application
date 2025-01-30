using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string? OwnerId { get; set; }
        public MusicStoreApplicationUser? Owner { get; set; }

        public ICollection<BoughtItem> BoughtItems { get; set; } = new List<BoughtItem>();

        public DateTime CreatedAt { get; set; }
    }
}
