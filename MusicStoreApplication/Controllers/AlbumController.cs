using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Web.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        private readonly IArtistService _artistService;

        public AlbumController(IAlbumService albumService, IArtistService artistService)
        {
            _albumService = albumService;
            _artistService = artistService;
        }
        // GET: Album
        public IActionResult Index()
        {
            var albums = _albumService.GetAllAlbums();
            return View(albums);
        }

        // GET: Album/Create
        public IActionResult Create()
        {
            var artists = _artistService.GetAllArtists()
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                })
                .ToList();

            ViewBag.Artists = artists;

            return View();
        }

        // POST: Album/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string title, DateTime releaseDate, Guid artistId)
        {
            try
            {
                // Call the service to create the album
                _albumService.CreateAlbum(title, releaseDate, artistId);
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                // Handle validation exceptions and display errors
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            catch (Exception ex)
            {
                // Handle generic exceptions
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
            }

            // Repopulate artists for the dropdown
            ViewBag.Artists = _artistService.GetAllArtists()
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                })
                .ToList();

            return View();
        }


        // GET: Album/Details/{id}
        public IActionResult Details(Guid id)
        {
            var album = _albumService.GetDetailsForAlbum(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }
        // GET: Album/Edit/{id}
        public IActionResult Edit(Guid id)
        {
            var album = _albumService.GetAlbumById(id);
            if (album == null)
            {
                return NotFound();
            }

            ViewBag.Artists = _artistService.GetAllArtists()
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name,
                    Selected = a.Id == album.ArtistId
                })
                .ToList();

            return View(album);
        }


        // POST: Album/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, string title, DateTime releaseDate)
        {
            try
            {
                // Update only the editable fields
                _albumService.UpdateAlbum(id, title, releaseDate);
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                // Handle validation exceptions
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            catch (Exception ex)
            {
                // Handle generic exceptions
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
            }

            // Reload artists for the dropdown
            var album = _albumService.GetAlbumById(id);
            if (album == null)
            {
                return NotFound();
            }

            ViewBag.Artists = _artistService.GetAllArtists()
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name,
                    Selected = a.Id == album.ArtistId
                })
                .ToList();

            return View(album);
        }

        // POST /Album/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Guid id)
        {
            _albumService.DeleteAlbum(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
