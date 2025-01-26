using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _trackRepository;
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IAlbumRepository _albumRepository;

        public TrackService(ITrackRepository trackRepository, IRepository<Ticket> ticketRepository, IArtistRepository artistRepository, IAlbumRepository albumRepository)
        {
            _trackRepository = trackRepository;
            _ticketRepository = ticketRepository;
            _artistRepository = artistRepository;
            _albumRepository = albumRepository;
        }

        public IEnumerable<Track> GetTracksForAlbum(Guid albumId)
        {
            var tracks = _trackRepository.GetTracksForAlbum(albumId);
            return tracks;
        }

        public Track GetTrackById(Guid trackId)
        {
            var track = _trackRepository.GetTrackById(trackId);
            if (track == null)
            {
                throw new Exception("Track not found");
            }

            return track;
        }

        /*public Ticket GetTicketForTrack(Guid trackId)
        {
            var track = GetTrackById(trackId);
            var ticket = _ticketRepository
                    .Where(t => t.TrackId == trackId)
                    .FirstOrDefault();
            if (ticket == null)
            {
                throw new Exception("Ticket not found for track");
            }

            return ticket;
        }*/
        public Track CreateTrack(TrackCreateViewModel track)
        {
            var artist = _artistRepository.Get(track.ArtistId);
            if (artist == null)
            {
                throw new ArgumentException("Artist not found.");
            }

            var album = _albumRepository.Get(track.AlbumId);
            if (album == null)
            {
                throw new ArgumentException("Album not found");
            }
            var song = new Track
            {
                Title = track.Title,
                Duration = track.Duration,
                AlbumId = track.Id,
                Album = album,
                Artist = artist,
                Price = track.Price
            };

            // Use the repository to insert the track
            return _trackRepository.AddTrack(song);
        }
        public Track UpdateTrack(Guid trackId, string title, TimeSpan duration, int price)
        {
            var track = _trackRepository.GetTrackById(trackId);
            if(track == null)
            {
                throw new ArgumentException("Track not found");
            }
            track.Title = title;
            track.Duration = duration;
            track.Price = price;
            _trackRepository.UpdateTrack(track);
            return track;
        }
        public void DeleteTrack(Guid trackId)
        {
            var track = _trackRepository.GetTrackById(trackId);
            if( track == null )
            {
                throw new ArgumentException("Track not found");
            }
            _trackRepository.DeleteTrack(track.Id);
        }
        public IEnumerable<Track> GetAllTracks()
        {
            return _trackRepository.GetAllTracks(); // Call the repository method to get all tracks
        }
    }
}
