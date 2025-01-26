using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class UserPlaylistService : IUserPlaylistService
    {
        private readonly IRepository<UserPlaylist> _playlistRepository;
        private readonly IRepository<Track> _trackRepository;
        private readonly IPlaylistRepository playlistRepositoryNew;
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IRepository<ShoppingCartItem> _shoppingCartItemRepository;
        private readonly ITrackRepository trackRepository1;
        private readonly IRepository<BoughtItem> _boughtItemRepository;

        public UserPlaylistService(IRepository<BoughtItem> _boughtItemRepository, ITrackRepository trackRepository1, IRepository<ShoppingCartItem> shoppingCartItemRepository, IRepository<ShoppingCart> shoppingCartRepository, IPlaylistRepository playlistRepositoryNew, IRepository<UserPlaylist> playlistRepository, IRepository<Track> trackRepository)
        {
            _playlistRepository = playlistRepository;
            _trackRepository = trackRepository;
            this.playlistRepositoryNew = playlistRepositoryNew;
            _shoppingCartRepository = shoppingCartRepository;
            _shoppingCartItemRepository = shoppingCartItemRepository;
            this.trackRepository1 = trackRepository1;
            this._boughtItemRepository = _boughtItemRepository;
        }

        public List<UserPlaylist> GetPlaylistsForUser(string userId)
        {
            return playlistRepositoryNew.GetAllPlaylists();
                
        }

        public void CreatePlaylist(string userId, string playlistName)
        {
            var playlist = new UserPlaylist
            {
                Id = Guid.NewGuid(),
                Name = playlistName,
                UserId = userId,
                Tracks = new List<Track>()
            };

            _playlistRepository.Insert(playlist);
        }

        public void AddTrackToPlaylist(Guid playlistId, Guid trackId, string userId)
        {
            var playlist = _playlistRepository.Get(playlistId);
            //var track = trackRepository1.GetTrackById(trackId);
            var track = _trackRepository.Get(trackId);
           
            if (playlist.Tracks == null)
            {
                playlist.Tracks = new List<Track>();
            }

            if (playlist != null && track != null)
            {
                playlist.Tracks.Add(track);
                _playlistRepository.Update(playlist);
            }
            
        }

        public void RemoveTrackFromPlaylist(Guid playlistId, Guid trackId)
        {
            var playlist = playlistRepositoryNew.GetPlaylistById(playlistId);

            if (playlist == null)
            {
                throw new ArgumentException("Playlist not found");
            }

            if (playlist.Tracks == null)
            {
                return; // No tracks to remove
            }

            var track = playlist.Tracks.FirstOrDefault(t => t.Id == trackId);

            if (track != null)
            {
                playlist.Tracks.Remove(track);
                _playlistRepository.Update(playlist);
            }
        }

        public void DeletePlaylist(Guid playlistId)
        {
            var playlist = _playlistRepository.Get(playlistId);
            if (playlist != null)
            {
                _playlistRepository.Delete(playlist);
            }
        }

        public UserPlaylist GetPlaylistDetails(Guid playlistId)
        {
            return playlistRepositoryNew.GetPlaylistById(playlistId);
        }

        public void RemoveTrackFromBoughtItems(Guid trackId)
        {
            
            _boughtItemRepository.Delete(_boughtItemRepository.GetAll().FirstOrDefault(i => i.ProductId == trackId));
            
        }
    }
}
