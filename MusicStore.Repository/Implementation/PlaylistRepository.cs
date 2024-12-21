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
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<UserPlaylist> entities;

        public PlaylistRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<UserPlaylist>();
        }

        public List<UserPlaylist> GetAllPlaylists()
        {
            return entities
                .Include(p => p.Tracks) // Include tracks in playlist
                .ToList();
        }

        public UserPlaylist GetPlaylistById(Guid id)
        {
            return entities
                .Include(p => p.Tracks)
                .FirstOrDefault(p => p.Id == id);
        }

        public UserPlaylist AddPlaylist(UserPlaylist playlist)
        {
            if (playlist == null)
            {
                throw new ArgumentNullException(nameof(playlist));
            }

            entities.Add(playlist);
            context.SaveChanges();
            return playlist;
        }

        public UserPlaylist UpdatePlaylist(UserPlaylist playlist)
        {
            if (playlist == null)
            {
                throw new ArgumentNullException(nameof(playlist));
            }

            entities.Update(playlist);
            context.SaveChanges();
            return playlist;
        }

        public void DeletePlaylist(Guid id)
        {
            var playlist = entities.FirstOrDefault(p => p.Id == id);
            if (playlist != null)
            {
                entities.Remove(playlist);
                context.SaveChanges();
            }
        }

        public UserPlaylist AddTrackToPlaylist(string userId, Guid trackId)
        {
            var userPlaylist = context.UserPlaylists
            .FirstOrDefault(p => p.UserId == userId);

            if (userPlaylist != null)
            {
                var track = context.Tracks
                    .FirstOrDefault(t => t.Id == trackId);

                if (track != null)
                {
                    userPlaylist.Tracks.Add(track);
                    context.SaveChanges();
                }
            }

            return userPlaylist;
        }

        public UserPlaylist AddAlbumToPlaylist(string userId, Guid albumId)
        {
            throw new NotImplementedException();
        }
    }
}
