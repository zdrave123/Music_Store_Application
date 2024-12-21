using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class UserPlaylist  : BaseEntity
    {
     
        public string? Name { get; set; }
        public ICollection<Track>? Tracks { get; set; }  // Many-to-many relationship
        public string? UserId { get; set; }
        public MusicStoreApplicationUser? User { get; set; }  // One-to-many relationship with User
    }
}
