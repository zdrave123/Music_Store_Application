using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IAlbumService
    {
        List<Album> GetAllAlbums();  // Get all albums
        Album GetDetailsForAlbum(Guid? id);  // Get details for a specific album
        void CreateNewAlbum(Album p);  // Create a new album
        void UpdateExistingAlbum(Album p);  // Update an existing album
        void DeleteAlbum(Guid id);  // Delete an album

        Album GetAlbumById(Guid albumId);  // Get album by ID
        List<Track> GetTracksForAlbum(Guid albumId);  // Get tracks for a specific album
        void AddAlbumToShoppingCart(Guid albumId, string userId);  // Add an album to shopping cart
        void AddTrackToShoppingCart(Guid trackId, string userId);  // Add a track to shopping cart
    }
}
