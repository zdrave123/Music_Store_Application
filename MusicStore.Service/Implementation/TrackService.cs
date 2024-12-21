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
    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _trackRepository;
        private readonly IRepository<Ticket> _ticketRepository;

        public TrackService(ITrackRepository trackRepository, IRepository<Ticket> ticketRepository)
        {
            _trackRepository = trackRepository;
            _ticketRepository = ticketRepository;
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
    }
}
