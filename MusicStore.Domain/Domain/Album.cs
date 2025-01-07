using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Album : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }

        public Guid ArtistId { get; set; } // Foreign key
        public Artist Artist { get; set; } = null!;

        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
