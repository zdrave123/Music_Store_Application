using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Track : BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public TimeSpan Duration { get; set; }
        public Guid AlbumId { get; set; } // Foreign key for Album
        public Album Album { get; set; } = null!;
        public Guid ArtistId { get; set; } // New foreign key for Artist
        public Artist Artist { get; set; } = null!;

        public int Price { get; set; }
        public ICollection<UserPlaylist>? Playlists { get; set; }
    }

}
