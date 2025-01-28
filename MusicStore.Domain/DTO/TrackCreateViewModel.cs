using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.DTO
{
        public class TrackCreateViewModel : BaseEntity
        {
            [Required]
            public string Title { get; set; } = string.Empty;

            [Required]
            public TimeSpan Duration { get; set; }

            [Required]
            public Guid ArtistId { get; set; }

            [Required]
            public Guid AlbumId { get; set; }

            [Required]
            public int Price { get; set; }

            [Required]
            public string? TrackImageUrl { get; set; }
        }
}
