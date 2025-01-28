using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface ITrackService
    {
        IEnumerable<Track> GetTracksForAlbum(Guid albumId);
        Track GetTrackById(Guid trackId);
        /*Ticket GetTicketForTrack(Guid trackId);*/
        Track CreateTrack(TrackCreateViewModel track);
        Track UpdateTrack(Guid trackId, string title, TimeSpan duration, int price, string TrackImageUrl);
        void DeleteTrack(Guid trackId);
        IEnumerable<Track> GetAllTracks();
    }
}
