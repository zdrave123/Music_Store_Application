using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Service.Interface;
using System.Security.Claims;

namespace MusicStore.Web.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShoppingCartService _shoppingCartService;
        private readonly IAlbumService _albumService;
        private readonly ITrackService _trackService;
        private readonly IOrderService _orderService;

        public ShoppingCartController(IOrderService orderService, IShoppingCartService shoppingCartService, IAlbumService albumService, ITrackService trackService)
        {
            _shoppingCartService = shoppingCartService;
            _albumService = albumService;
            _trackService = trackService;
            _orderService = orderService;
        }

        public IActionResult ViewCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;
            var cartItems = _shoppingCartService.GetCartItems(userId);
            var totalPrice = cartItems.Sum(item => item.Price);
            var boughtItems = new List<BoughtItem>();
            foreach (var cartItem in cartItems)
            {
                BoughtItem boughtItem = new BoughtItem
                {
                    Id = Guid.NewGuid(),
                    Price = cartItem.Price,
                    ProductId = cartItem.ProductId,
                    ProductName = cartItem.ProductName,
                    ProductType = cartItem.ProductType,
                };

                boughtItems.Add(boughtItem);

            }
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cartItems,
                TotalPrice = totalPrice,
                BoughtItems = boughtItems,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;

            if (userId != null)
            {
                _shoppingCartService.RemoveItemFromCart(id, userId);
            }
            
            return RedirectToAction("ViewCart");
        }


        public IActionResult ClearCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;
            
            var shoppingCart = _shoppingCartService.GetCartForUser(userId);

            _shoppingCartService.ClearCart(userId);

            return RedirectToAction("ViewCart");
        }

        [HttpPost]
        public IActionResult Checkout(List<BoughtItem> BoughtItems)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;
            var order = _orderService.CreateOrder(userId, BoughtItems);
            _shoppingCartService.BuyTracks(userId, BoughtItems);
            
            _shoppingCartService.ClearCart(userId);
            /*return RedirectToAction("ManagePlaylists", "UserPlaylist");*/
            return RedirectToAction("Details", "Order", new { id = order.Id });
        }

    }
}
