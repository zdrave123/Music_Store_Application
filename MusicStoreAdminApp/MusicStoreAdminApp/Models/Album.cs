using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdminApp.Models
{
    public class Album : BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public DateTime ReleaseDate { get; set; }

        public Guid ArtistId { get; set; } // Foreign key
        public Artist Artist { get; set; } = null!;

        public int Price { get; set; }

        public string? AlbumImageUrl { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
