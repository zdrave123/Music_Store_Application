using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStoreApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Implementation
{
    public class TrackRepository : ITrackRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Track> entities;

        public TrackRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Track>();
        }

        public IEnumerable<Track> GetTracksForAlbum(Guid albumId)
        {
            return context.Tracks
                .Where(t => t.Id == albumId)  // Assuming 'AlbumId' is a foreign key in 'Track'
                .ToList();
        }

        public List<Track> GetAllTracks()
        {
            return entities.ToList();
        }

        public Track GetTrackById(Guid id)
        {
            return entities.FirstOrDefault(t => t.Id == id);
        }

        public Track AddTrack(Track track)
        {
            if (track == null)
            {
                throw new ArgumentNullException(nameof(track));
            }

            entities.Add(track);
            context.SaveChanges();
            return track;
        }

        public Track UpdateTrack(Track track)
        {
            if (track == null)
            {
                throw new ArgumentNullException(nameof(track));
            }

            entities.Update(track);
            context.SaveChanges();
            return track;
        }

        public void DeleteTrack(Guid id)
        {
            var track = entities.FirstOrDefault(t => t.Id == id);
            if (track != null)
            {
                entities.Remove(track);
                context.SaveChanges();
            }
        }
    }
}
