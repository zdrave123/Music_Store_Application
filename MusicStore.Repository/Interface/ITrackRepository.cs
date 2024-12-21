using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface ITrackRepository
    {
        List<Track> GetAllTracks();
        Track GetTrackById(Guid id);
        Track AddTrack(Track track);
        Track UpdateTrack(Track track);
        void DeleteTrack(Guid id);

        IEnumerable<Track> GetTracksForAlbum(Guid albumId);
    }
}
