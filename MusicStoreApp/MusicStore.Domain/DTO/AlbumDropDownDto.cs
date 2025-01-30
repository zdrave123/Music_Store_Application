using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.DTO
{
    public class AlbumDropDownDto :BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
