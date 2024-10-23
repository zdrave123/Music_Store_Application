using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Accessory : Product
    {
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
