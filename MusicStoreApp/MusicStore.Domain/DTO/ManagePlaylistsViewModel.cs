using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.DTO
{
    public class ManagePlaylistsViewModel
    {
        public List<UserPlaylist> Playlists { get; set; }
        public List<BoughtItem> BoughtItems { get; set; }
    }
}
