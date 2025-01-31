using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;

namespace MusicStore.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPlaylistRepository _playlistRepository;


        public AdminController(IOrderRepository orderRepository, IPlaylistRepository playlistRepository)
        {
            _orderRepository = orderRepository;
            _playlistRepository = playlistRepository;
        }

        [HttpGet("GetOrderList")]
        public List<Order> GetOrderList()
        {
            return _orderRepository.GetAllOrders();
        }

        [HttpPost("[action]")]
        public Order OrderDetails(BaseEntity id)
        {
            return _orderRepository.GetOrderDetails(id);
        }

        [HttpGet("GetPlaylist")]
        public List<UserPlaylist> GetPlaylistList()
        {
            return _playlistRepository.GetAllPlaylists();
        }

        [HttpPost("[action]")]
        public UserPlaylist PlaylistDetails(BaseEntity id)
        {
            return _playlistRepository.GetPlaylistById(id);
        }

    }
}
