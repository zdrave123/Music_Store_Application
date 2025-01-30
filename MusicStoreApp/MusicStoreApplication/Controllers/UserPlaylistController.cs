using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Service.Implementation;
using MusicStore.Service.Interface;
using System.Security.Claims;

namespace MusicStore.Web.Controllers
{
    public class UserPlaylistController : Controller
    {
        private readonly IUserPlaylistService _playlistService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IAlbumService _albumService;
        private readonly ITrackService _trackService;

        public UserPlaylistController(ITrackService trackService, IAlbumService albumService, IUserPlaylistService playlistService, IShoppingCartService shoppingCartService)
        {
            _playlistService = playlistService;
            _shoppingCartService = shoppingCartService;
            _albumService = albumService;
            _trackService = trackService;
      
        }

        public IActionResult ManagePlaylists()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var playlists = _playlistService.GetPlaylistsForUser(userId);

            var boughtItems = _shoppingCartService.GetBoughtItems(userId);

            var viewModel = new ManagePlaylistsViewModel
            {
                Playlists = playlists,
                BoughtItems = boughtItems
            };
            
           
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreatePlaylist(string playlistName)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _playlistService.CreatePlaylist(userId, playlistName);

            return RedirectToAction("ManagePlaylists");
        }

        [HttpPost]
        public IActionResult AddTrackToPlaylist(Guid playlistId, Guid trackId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var model = new BaseEntity
            {
                Id = playlistId
            };

            _playlistService.AddTrackToPlaylist(model, trackId, userId);
            
            return RedirectToAction("ManagePlaylists");
        }


        [HttpPost]
        public IActionResult AddAlbumToPlaylist(Guid playlistId, Guid albumId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var albumTracks = _albumService.GetTracksForAlbum(albumId);
            var model = new BaseEntity
            {
                Id = playlistId
            };
            foreach (var track in albumTracks)
            {
                _playlistService.AddTrackToPlaylist(model, track.Id, userId);
            }
            return RedirectToAction("ManagePlaylists");
        }

        [HttpPost]
        public IActionResult DeletePlaylist(Guid playlistId)
        {
            _playlistService.DeletePlaylist(playlistId);
            return RedirectToAction("ManagePlaylists");
        }


        public IActionResult PlaylistDetails(Guid playlistId)
        {
            var model = new BaseEntity
            {
                Id = playlistId
            };
            var playlist = _playlistService.GetPlaylistDetails(model);
            return View(playlist);
        }

        [HttpPost]
        public IActionResult RemoveTrackFromPlaylist(Guid playlistId, Guid trackId)
        {
            var model = new BaseEntity
            {
                Id = playlistId
            };
            _playlistService.RemoveTrackFromPlaylist(model, trackId);

            return RedirectToAction("PlaylistDetails", new { playlistId = playlistId });
        }


        [HttpPost]
        public IActionResult RemoveTrackConfirmation(Guid id)
        {
            var track = _trackService.GetTrackById(id); 
            if (track == null)
            {
                return NotFound();
            }

            return View(track); 
        }

        [HttpPost]
        public IActionResult RemoveAlbumConfirmation(Guid id)
        {
            var album = _albumService.GetAlbumById(id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }


        [HttpPost]
        public IActionResult RemoveTrack(Guid id)
        {
            var track = _trackService.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            _playlistService.RemoveItemFromBoughtItems(id);
            return RedirectToAction("ManagePlaylists"); 
        }


        [HttpPost]
        public IActionResult RemoveAlbum(Guid id)
        {
            var album = _albumService.GetAlbumById(id);
            if (album == null)
            {
                return NotFound();
            }
            
            _playlistService.RemoveItemFromBoughtItems(id);
            
            return RedirectToAction("ManagePlaylists");
        }
    }
}
