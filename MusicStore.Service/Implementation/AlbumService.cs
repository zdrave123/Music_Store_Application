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
        private readonly IShoppingCartService _shoppingCartService;
      

        public AlbumService(IShoppingCartService shoppingCartService, IAlbumRepository albumRepository, ITrackRepository trackRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _albumRepository = albumRepository;
            _trackRepository = trackRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _shoppingCartService = shoppingCartService;
        }

        public List<Album> GetAllAlbums()
        {
            return (List<Album>)_albumRepository.GetAll();  // Get all albums
        }

        public Album GetDetailsForAlbum(Guid? id)
        {
            return _albumRepository.Get(id.Value);  // Get details of a specific album
        }
        public void CreateAlbum(string title, DateTime releaseDate, Guid artistId, int price, string AlbumImageUrl)
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
                ArtistId = artistId,
                Price = price,
                AlbumImageUrl = AlbumImageUrl,
            };

            _albumRepository.Insert(album);
        }

        public void UpdateAlbum(Guid id, string title, DateTime releaseDate, int price, string AlbumImageUrl)
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
            album.Price = price;
            album.AlbumImageUrl = AlbumImageUrl;

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
            return _trackRepository.GetTracksForAlbum(albumId).ToList();  // Get tracks for the album
        }

        /*public void AddAlbumToShoppingCart(Guid albumId, string userId)
        {
            // Get the album details
            var album = _albumRepository.Get(albumId);

            // Create a ShoppingCartItem for the album
            var albumItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid(),
                ProductId = albumId,
                ProductName = album.Title,
                Price = album.Price,
                ProductType = "Album"
            };

            // Add the album to the shopping cart for the user
            _shoppingCartService.AddItemToCart(userId, albumItem);

            // Get all tracks associated with the album
            var tracks = _trackRepository.GetTracksForAlbum(albumId);

            // Add each track as a ShoppingCartItem
            foreach (var track in tracks)
            {
                var trackItem = new ShoppingCartItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = track.Id,
                    ProductName = track.Title,
                    Price = track.Price,
                    ProductType = "Track"
                };

                // Add the track to the shopping cart for the user
                _shoppingCartService.AddItemToCart(userId, trackItem);
            }
        }

        public void AddTrackToShoppingCart(Guid trackId, string userId)
        {
            // Get the track details
            var track = _trackRepository.GetTrackById(trackId);

            // Create a ShoppingCartItem for the track
            var trackItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid(),
                ProductId = trackId,
                ProductName = track.Title,
                Price = track.Price,
                ProductType = "Track"
            };

            // Add the track to the shopping cart for the user
            _shoppingCartService.AddItemToCart(userId, trackItem);
        }*/

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

