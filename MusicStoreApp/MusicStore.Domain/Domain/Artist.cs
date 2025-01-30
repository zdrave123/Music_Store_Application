using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public class Artist : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public ICollection<Album> Albums { get; set; } = new List<Album>();
        public ICollection<Track> Tracks { get;} = new List<Track>();
    }
}
