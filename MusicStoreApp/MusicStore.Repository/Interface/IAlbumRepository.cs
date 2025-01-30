using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<Album> GetAlbumByIdAsync(Guid albumId);
        Task<List<Track>> GetTracksForAlbumAsync(Guid albumId);

        List<Album> GetAlbumsByArtist(Guid artistId);
    }
}
