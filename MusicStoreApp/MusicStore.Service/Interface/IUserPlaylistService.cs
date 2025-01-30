using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IUserPlaylistService
    {
        List<UserPlaylist> GetPlaylistsForUser(string userId);
        void CreatePlaylist(string userId, string playlistName);
        void AddTrackToPlaylist(BaseEntity playlistId, Guid trackId, string userId);
        void RemoveTrackFromPlaylist(BaseEntity playlistId, Guid trackId);
        void DeletePlaylist(Guid playlistId);
        UserPlaylist GetPlaylistDetails(BaseEntity playlistId);
        void RemoveItemFromBoughtItems(Guid id);
       
    }
}
