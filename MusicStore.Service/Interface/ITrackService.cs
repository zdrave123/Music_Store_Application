using MusicStore.Domain.Domain;
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

    }
}
