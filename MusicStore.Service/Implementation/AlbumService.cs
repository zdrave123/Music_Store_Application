using MusicStore.Domain.Domain;
using MusicStore.Repository.Implementation;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class AlbumService : IAlbumService
    {
       
        private readonly IAlbumRepository _albumRepository;
        private readonly ITrackRepository _trackRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IRepository<Ticket> _ticketRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public List<Album> GetAllAlbums()
        {
            return (List<Album>)_albumRepository.GetAll();  // Get all albums
        }

        public Album GetDetailsForAlbum(Guid? id)
        {
            return _albumRepository.Get(id.Value);  // Get details of a specific album
        }

        public void CreateNewAlbum(Album p)
        {
            _albumRepository.Insert(p);  // Add a new album
        }

        public void UpdateExistingAlbum(Album p)
        {
            _albumRepository.Update(p);  // Update an existing album
        }

        public void DeleteAlbum(Guid id)
        {
            var album = _albumRepository.Get(id);
            _albumRepository.Delete(album);  // Delete an album
        }

        public Album GetAlbumById(Guid albumId)
        {
            return _albumRepository.Get(albumId);  // Get album by its ID
        }

        public List<Track> GetTracksForAlbum(Guid albumId)
        {
            return (List<Track>)_trackRepository.GetTracksForAlbum(albumId);  // Get tracks for the album
        }

        public void AddAlbumToShoppingCart(Guid albumId, string userId)
        {
            var album = _albumRepository.Get(albumId);
            // Logic to add all tracks from album to shopping cart for the user
            var tracks = _trackRepository.GetTracksForAlbum(albumId);
            foreach (var track in tracks)
            {
                _shoppingCartRepository.AddTrackToCart(track.Id, userId);  // Add each track to the user's shopping cart
            }
        }

        public void AddTrackToShoppingCart(Guid trackId, string userId)
        {
            _shoppingCartRepository.AddTrackToCart(trackId, userId);  // Add a single track to the user's shopping cart
        }
    }
}

