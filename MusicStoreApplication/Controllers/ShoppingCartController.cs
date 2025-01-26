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

        public ShoppingCartController(IShoppingCartService shoppingCartService, IAlbumService albumService, ITrackService trackService)
        {
            _shoppingCartService = shoppingCartService;
            _albumService = albumService;
            _trackService = trackService;
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
            _shoppingCartService.BuyTracks(userId, BoughtItems);
            return RedirectToAction("ManagePlaylists", "UserPlaylist");
        }

    }
}
