using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<Artist> GetArtistByIdAsync(Guid artistId);
        Task<List<Album>> GetAlbumsByArtistAsync(Guid artistId);
    }
}
