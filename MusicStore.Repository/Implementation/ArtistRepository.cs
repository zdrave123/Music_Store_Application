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
    public class ArtistRepository : IArtistRepository
    {
        private readonly ApplicationDbContext _context;

        public ArtistRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Generic CRUD operations
        public IEnumerable<Artist> GetAll()
        {
            return _context.Artists.Include(a => a.Albums).ToList();
        }

        public Artist Get(Guid? id)
        {
            return _context.Artists.Include(a => a.Albums).FirstOrDefault(a => a.Id == id);
        }

        public Artist Insert(Artist entity)
        {
            _context.Artists.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public List<Artist> InsertMany(List<Artist> entities)
        {
            _context.Artists.AddRange(entities);
            _context.SaveChanges();
            return entities;
        }

        public Artist Update(Artist entity)
        {
            _context.Artists.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public Artist Delete(Artist entity)
        {
            _context.Artists.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        // Custom methods
        public async Task<Artist> GetArtistByIdAsync(Guid artistId)
        {
            return await _context.Artists.Include(a => a.Albums).FirstOrDefaultAsync(a => a.Id == artistId);
        }

        public async Task<List<Album>> GetAlbumsByArtistAsync(Guid artistId)
        {
            var artist = await _context.Artists.Include(a => a.Albums).FirstOrDefaultAsync(a => a.Id == artistId);
            return artist?.Albums.ToList() ?? new List<Album>();
        }
    }
}
