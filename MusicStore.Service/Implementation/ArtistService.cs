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
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IAlbumRepository _albumRepository;

        public ArtistService(IArtistRepository artistRepository, IAlbumRepository albumRepository)
        {
            _artistRepository = artistRepository;
            _albumRepository = albumRepository;
        }

        public List<Artist> GetAllArtists()
        {
            return (List<Artist>)_artistRepository.GetAll();
        }

        public Artist GetArtistById(Guid artistId)
        {
            var artist = _artistRepository.Get(artistId);
            if (artist == null)
                throw new Exception("Artist not found");
            return artist;
        }

        public List<Album> GetAlbumsByArtist(Guid artistId)
        {
            var albums = _albumRepository.GetAlbumsByArtist(artistId);
            if (albums == null || albums.Count == 0)
                throw new Exception("No albums found for this artist");
            return albums;
        }

        public Artist CreateArtist(Artist artist)
        {
            if (artist == null)
                throw new ArgumentNullException(nameof(artist));

            return _artistRepository.Insert(artist);
        }

        public Artist UpdateArtist(Artist artist)
        {
            if (artist == null)
                throw new ArgumentNullException(nameof(artist));

            var existingArtist = _artistRepository.Get(artist.Id);
            if (existingArtist == null)
                throw new Exception("Artist not found");

            return _artistRepository.Update(artist);
        }

        public Artist DeleteArtist(Guid artistId)
        {
            var artist = _artistRepository.Get(artistId);
            if (artist == null)
                throw new Exception("Artist not found");

            return _artistRepository.Delete(artist);
        }
    }
}
