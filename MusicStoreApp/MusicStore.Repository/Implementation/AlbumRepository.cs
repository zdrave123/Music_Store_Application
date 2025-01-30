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
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext context;
        //private DbSet<Album> entities;

        public AlbumRepository(ApplicationDbContext context)
        {
            this.context = context;
            //entities = context.Set<Album>();
        }

        public IEnumerable<Album> GetAll()
        {
            return context.Albums.Include(a => a.Artist).Include(a => a.Tracks).ToList();
        }

        public Album Get(Guid? id)
        {
            return context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Tracks)
                .FirstOrDefault(a => a.Id == id);
        }

        public Album Insert(Album album)
        {
            Console.WriteLine($"Inserting Album: Title={album.Title}, ReleaseDate={album.ReleaseDate}, ArtistId={album.ArtistId}");
            context.Albums.Add(album);
            context.SaveChanges();
            return album;
        }

        public List<Album> InsertMany(List<Album> entities)
        {
            context.Albums.AddRange(entities);
            context.SaveChanges();
            return entities;
        }

        public List<Album> GetAlbumsByArtist(Guid artistId)
        {
            return context.Albums
                .Where(a => a.ArtistId == artistId)
                .Include(a => a.Artist)
                .Include(a => a.Tracks)
                .ToList();
        }

        public Album Update(Album entity)
        {
            context.Albums.Attach(entity); // Attach the entity to the context
            context.Entry(entity).Property(a => a.Title).IsModified = true;
            context.Entry(entity).Property(a => a.ReleaseDate).IsModified = true;

            // Ensure ArtistId is not marked as modified
            context.Entry(entity).Property(a => a.ArtistId).IsModified = false;

            context.SaveChanges();
            return entity;
        }


        public Album Delete(Album entity)
        {
            context.Albums.Remove(entity);
            context.SaveChanges();
            return entity;
        }

        public async Task<Album> GetAlbumByIdAsync(Guid albumId)
        {
            return await context.Albums.Include(a => a.Tracks).FirstOrDefaultAsync(a => a.Id == albumId);
        }

        public async Task<List<Track>> GetTracksForAlbumAsync(Guid albumId)
        {
            var album = await context.Albums.Include(a => a.Tracks).FirstOrDefaultAsync(a => a.Id == albumId);
            return album?.Tracks.ToList() ?? new List<Track>();
        }
    }
}
