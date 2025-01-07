using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Track : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; }
        public Guid AlbumId { get; set; } // Foreign key for Album
        public Album Album { get; set; } = null!;
        public ICollection<Artist> Artists { get; set; } = new List<Artist>();
        public ICollection<UserPlaylist>? Playlists { get; set; }
    }

}
