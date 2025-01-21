using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Repository.Implementation;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public AlbumService(IAlbumRepository albumRepository, ITrackRepository trackRepository, IShoppingCartRepository shoppingCartRepository, IRepository<Ticket> repository)
        {
            _albumRepository = albumRepository;
            _trackRepository = trackRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _ticketRepository = repository;
        }

        public List<Album> GetAllAlbums()
        {
            return (List<Album>)_albumRepository.GetAll();  // Get all albums
        }

        public Album GetDetailsForAlbum(Guid? id)
        {
            return _albumRepository.Get(id.Value);  // Get details of a specific album
        }
        public void CreateAlbum(string title, DateTime releaseDate, Guid artistId)
        {
            // Perform validation and throw exceptions for invalid input
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title is required.");
            }

            if (releaseDate == default)
            {
                throw new ArgumentException("Valid release date is required.");
            }

            if (artistId == Guid.Empty)
            {
                throw new ArgumentException("Please select a valid artist.");
            }

            // Create and insert the album
            var album = new Album
            {
                Id = Guid.NewGuid(),
                Title = title,
                ReleaseDate = releaseDate,
                ArtistId = artistId
            };

            _albumRepository.Insert(album);
        }

        public void UpdateAlbum(Guid id, string title, DateTime releaseDate)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title is required.");
            }

            if (releaseDate == default)
            {
                throw new ArgumentException("Valid release date is required.");
            }

            var album = _albumRepository.Get(id);
            if (album == null)
            {
                throw new Exception("Album not found.");
            }

            // Update only the fields that are editable
            album.Title = title;
            album.ReleaseDate = releaseDate;

            _albumRepository.Update(album);
        }


        public void DeleteAlbum(Guid id)
        {
            var album = _albumRepository.Get(id);
            if (album == null)
            {
                throw new Exception("Album not found");
            }
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
        public IEnumerable<AlbumDropDownDto> GetAlbumsByArtist(Guid artistId)
        {
            return _albumRepository.GetAlbumsByArtist(artistId)
                .Select(a => new AlbumDropDownDto
                {
                    Id = a.Id,
                    Title = a.Title
                })
                .ToList();
        }
    }
}

