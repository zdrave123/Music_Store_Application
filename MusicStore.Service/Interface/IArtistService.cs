using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IArtistService
    {
        List<Artist> GetAllArtists();
        Artist GetArtistById(Guid artistId);
        List<Album> GetAlbumsByArtist(Guid artistId);
        Artist CreateArtist(Artist artist);
        Artist UpdateArtist(Artist artist);
        Artist DeleteArtist(Guid artistId);
    }
}
