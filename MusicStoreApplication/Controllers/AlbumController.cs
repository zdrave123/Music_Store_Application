using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Service.Interface;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace MusicStore.Web.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        private readonly IArtistService _artistService;
        private readonly ITrackService _trackService;
        private readonly IShoppingCartService _shoppingCartService;

        public AlbumController(ITrackService trackService, IShoppingCartService shoppingCartService, IAlbumService albumService, IArtistService artistService)
        {
            _albumService = albumService;
            _artistService = artistService;
            _shoppingCartService = shoppingCartService;
            _trackService = trackService;
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
        public IActionResult Create(string title, DateTime releaseDate, Guid artistId, int price)
        {
            try
            {
                // Call the service to create the album
                _albumService.CreateAlbum(title, releaseDate, artistId, price);
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
        public IActionResult Edit(Guid id, string title, DateTime releaseDate, int price)
        {
            try
            {
                // Update only the editable fields
                _albumService.UpdateAlbum(id, title, releaseDate, price);
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


        [HttpPost]
        public IActionResult AddToCart(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;

            // Get the album details
            var album = _albumService.GetAlbumById(id);

            // Create a ShoppingCartItem for the album
            var albumItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid(),
                ProductId = id,
                ProductName = album.Title,
                Price = album.Price,
                ProductType = "Album"
            };

            // Add the album to the shopping cart for the user
            _shoppingCartService.AddItemToCart(userId, albumItem);

            // Get all tracks associated with the album
            var tracks = _trackService.GetTracksForAlbum(id);

            // Add each track as a ShoppingCartItem
            foreach (var track in tracks)
            {
                var trackItem = new ShoppingCartItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = track.Id,
                    ProductName = track.Title,
                    Price = track.Price,
                    ProductType = "Track"
                };

                // Add the track to the shopping cart for the user
                _shoppingCartService.AddItemToCart(userId, trackItem);
            }
            return RedirectToAction("ViewCart", "ShoppingCart");
        }
    }
}
