using MusicStore.Domain.Domain;
using MusicStore.Domain.DTO;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Repository.Implementation;
using MusicStoreApplication.Repository;
using System.Security.Claims;
using NuGet.Packaging;
using MusicStore.Domain.Identity;

namespace MusicStore.Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IRepository<ShoppingCartItem> _shoppingCartItemRepository;
        private readonly IRepository<BoughtItem> _boughtItemRepository;
        private readonly ITrackRepository trackRepository;
        private readonly IAlbumRepository albumRepository;
        private readonly IUserRepository userRepository;
        private readonly ApplicationDbContext _context;

        public ShoppingCartService(IAlbumRepository albumRepository, IRepository<BoughtItem> boughtItemRepository, IUserRepository userRepository, ITrackRepository trackRepository, IRepository<ShoppingCartItem> shoppingCartItemRepository, IShoppingCartRepository shoppingCartRepository, IRepository<ShoppingCart> _shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this._shoppingCartRepository = _shoppingCartRepository;
            _shoppingCartItemRepository = shoppingCartItemRepository;
            this.trackRepository = trackRepository;
            this.userRepository = userRepository;
            _boughtItemRepository = boughtItemRepository;
            this.albumRepository = albumRepository;
        }

        public ShoppingCart GetCartForUser(string userId)
        {
            return shoppingCartRepository.GetCartForUser(userId);
        }

        /*public void AddTicketToCart(string userId, Ticket ticket)
        {
            shoppingCartRepository.AddTicketToCart(userId, ticket);
        }

        public void RemoveTicketFromCart(string userId, Guid ticketId)
        {
            shoppingCartRepository.RemoveTicketFromCart(userId, ticketId);
        }*/

        public void ClearCart(string userId)
        {
            shoppingCartRepository.ClearCart(userId);
        }

        public List<ShoppingCartItem> GetCartItems(string userId)
        {
            var shoppingCart = shoppingCartRepository.GetCartForUser(userId);
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart
                {
                    OwnerId = userId
                };
                _shoppingCartRepository.Insert(shoppingCart);
            }
            return shoppingCart.Items.ToList();
        }
        
        public List<BoughtItem> GetBoughtItems(string userId)
        {
           
          
            return _boughtItemRepository.GetAll().ToList();
            
          
        }

        public void AddItemToCart(string userId, ShoppingCartItem item)
        {
            var shoppingCart = shoppingCartRepository.GetCartForUser(userId);
            
          
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart { OwnerId = userId };
               // shoppingCartRepository.SaveCart(shoppingCart);
                _shoppingCartRepository.Insert(shoppingCart);
            }

            if (!shoppingCart.Items.Any(i => i.ProductId == item.ProductId && i.ProductType == item.ProductType))
            {
                shoppingCart.Items.Add(item);
                _shoppingCartItemRepository.Insert(item);
            }

            // shoppingCartRepository.SaveCart(shoppingCart);

            _shoppingCartRepository.Update(shoppingCart);
           
        }

        public void RemoveItemFromCart(Guid id, string userId)
        {
            var shoppingCart = shoppingCartRepository.GetCartForUser(userId) ?? throw new InvalidOperationException("Shopping cart not found for the user.");
            var item = shoppingCart.Items.FirstOrDefault(item => item.Id == id) ?? throw new InvalidOperationException("Item not found in the shopping cart.");
            
            shoppingCart.Items.Remove(item);

            _shoppingCartItemRepository.Delete(item);

            _shoppingCartRepository.Update(shoppingCart);
        }

        public void BuyTracks(string userId, List<BoughtItem> items)
        {
            foreach (var item in items)
            {
                if (!_boughtItemRepository.GetAll().Any(i => i.ProductId == item.ProductId)) { 
                     _boughtItemRepository.Insert(item);
                }
            }
        }

        /*public void Checkout(string userId)
        {
            var shoppingCart = _context.ShoppingCarts
                .Include(cart => cart.Items)
                .FirstOrDefault(cart => cart.OwnerId == userId);

            if (shoppingCart != null)
            {
                // Create a list of bought items (can be tracks or albums)
                var boughtItems = shoppingCart.Items.ToList();

                var user = _context.Users
                    .Include(u => u.MyPlaylists) // Include playlists if needed
                    .FirstOrDefault(u => u.Id == userId);

                if (user != null)
                {
                    // Optionally, create a new list for the bought items or add them to a "bought" collection
                    user.MyPlaylists?.ToList().ForEach(playlist =>
                    {
                        // Here we can add the bought items to the playlist for easy access
                        foreach (var item in boughtItems)
                        {
                            if (item.Track)
                            {
                                playlist.Tracks.Add(item.);
                            }
                            else if (item.Album != null)
                            {
                                // Assuming your cart items may contain albums too
                                playlist.Tracks.AddRange(item.Album.Tracks);
                            }
                        }
                    });

                    
                }

                // Optionally clear the cart after storing items
                shoppingCart.Items.Clear();
                _shoppingCartRepository.Update(shoppingCart);
            }
        }*/
    }
    }

