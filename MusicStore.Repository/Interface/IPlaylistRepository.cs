using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IPlaylistRepository
    {
        List<UserPlaylist> GetAllPlaylists();
        UserPlaylist GetPlaylistById(Guid id);
        UserPlaylist AddPlaylist(UserPlaylist playlist);
        UserPlaylist UpdatePlaylist(UserPlaylist playlist);
        UserPlaylist AddTrackToPlaylist(string userId, Guid trackId);
        UserPlaylist AddAlbumToPlaylist(string userId, Guid albumId);
        void DeletePlaylist(Guid id);
    }
}
