using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain.Domain;
using MusicStore.Service.Interface;

namespace MusicStore.Web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService ?? throw new ArgumentNullException(nameof(artistService));
        }
        // Get Artists
        public IActionResult Index()
        {
            var artists = _artistService.GetAllArtists();
            return View(artists);
        }

        // Get  /Artist/Details/{id}
        public IActionResult Details(Guid id) 
        {
            var artist = _artistService.GetArtistById(id);
            return View(artist);
        }

        // Get /Artist/Create
        [HttpGet]
        public IActionResult Create ()
        {
            return View();
        }

        // Post /Artist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Artist artist)
        {
            if (ModelState.IsValid)
            {
                _artistService.CreateArtist(artist);
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        // Get /Artist/Edit/{id}
        [HttpGet]
        public IActionResult Edit (Guid id) 
        {
            var artist = _artistService.GetArtistById(id);
            return View(artist);
        }
        // Post /Artist/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Artist artist)
        {
            if (ModelState.IsValid)
            {
                _artistService.UpdateArtist(artist);
                return RedirectToAction("Index");
            }
            return View(artist);
        }
        // POST /Artist/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _artistService.DeleteArtist(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
