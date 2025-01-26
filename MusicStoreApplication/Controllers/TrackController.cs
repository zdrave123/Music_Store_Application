using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Service.Interface;
using NuGet.DependencyResolver;
using System.Security.Claims;

namespace MusicStore.Web.Controllers
{
    public class TrackController : Controller
    {
        private readonly ITrackService _trackService;
        private readonly IAlbumService _albumService;
        private readonly IArtistService _artistService;
        private readonly IShoppingCartService _shoppingCartService;

        public TrackController(IShoppingCartService shoppingCartService, ITrackService trackService, IAlbumService albumService, IArtistService artistService)
        {
            _trackService = trackService;
            _albumService = albumService;
            _artistService = artistService;
            _shoppingCartService = shoppingCartService;
        }
        public IActionResult Index()
        {
            var tracks = _trackService.GetAllTracks();
            return View(tracks);
        }
        // GET: Tracks/Details/{id}
        public IActionResult Details(Guid id)
        {
            try
            {
                var track = _trackService.GetTrackById(id);
                return View(track);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // GET: Create Track
        [HttpGet]
        public IActionResult Create(Guid artistId)
        {
            var artists = _artistService.GetAllArtists(); // Fetch all artists
            ViewBag.Artists = artists;

            // If artistId is provided, load albums for that artist
            var albums = _albumService.GetAllAlbums();

            ViewBag.Albums = albums;

            return View();
        }
        [HttpGet]
        public JsonResult GetAlbumsByArtist(Guid artistId)
        {
            var albums = _albumService.GetAlbumsByArtist(artistId);
            return Json(albums.Select(album => new { id = album.Id, title = album.Title }));
        }

        // POST: Tracks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TrackCreateViewModel trackCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(trackCreateViewModel);
            }

            try
            {
                var createdTrack = _trackService.CreateTrack(trackCreateViewModel);
                return RedirectToAction(nameof(Index), new { albumId = createdTrack.AlbumId });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(trackCreateViewModel);
            }
        }

        // GET: Tracks/Edit/{id}
        public IActionResult Edit(Guid id)
        {
            var track = _trackService.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }
            // Populate dropdown lists for artists and albums
            ViewBag.Artists = _artistService.GetAllArtists(); // Assuming this method returns a list of artists
            ViewBag.Albums = _albumService.GetAllAlbums();   // Assuming this method returns a list of albums
            // Pass the track directly to the view
            return View(track);
        }

        // POST: Tracks/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, string title, TimeSpan duration, int price)
        {
            if (string.IsNullOrWhiteSpace(title) || duration.TotalSeconds <= 0)
            {
                ModelState.AddModelError(string.Empty, "Invalid input data.");
                return View(new Track { Id = id, Title = title, Duration = duration, Price = price });
            }

            try
            {
                var updatedTrack = _trackService.UpdateTrack(id, title, duration, price);
                return RedirectToAction(nameof(Index), new { albumId = updatedTrack.AlbumId });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(new Track { Id = id, Title = title, Duration = duration, Price = price });
            }
        }
        // GET: Tracks/Delete/{id}
        public IActionResult Delete(Guid id)
        {
            var track = _trackService.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        // POST: Tracks/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _trackService.DeleteTrack(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult AddToCart(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;

            // Get the track details
            var track = _trackService.GetTrackById(id);

            // Create a ShoppingCartItem for the track
            var trackItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid(),
                ProductId = id,
                ProductName = track.Title,
                Price = track.Price,
                ProductType = "Track"
            };

            // Add the track to the shopping cart for the user
            _shoppingCartService.AddItemToCart(userId, trackItem);

            return RedirectToAction("ViewCart", "ShoppingCart");
        }
    }
}
