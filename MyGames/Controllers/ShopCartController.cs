using Microsoft.AspNetCore.Mvc;
using MyGames.Models;
using MyGames.Repositories.Interfaces;
using MyGames.ViewModels;

namespace MyGames.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IGameRepository gameRepository, ShopCart shopCart)
        {
            _gameRepository = gameRepository;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            var items = _shopCart.GetShopCartItems();
            _shopCart.ShopCartItems = items;

            var shopCartVM = new ShopCartViewModel
            {
                ShopCart = _shopCart,
                ShopCartTotal = _shopCart.GetShopCartTotal()
            };
            return View(shopCartVM);
        }

        public IActionResult AddItemToShopCart( int gameId)
        {
            var selectedGame = _gameRepository.Games.FirstOrDefault(g => g.GameId == gameId);

            if (selectedGame != null) 
            {
                _shopCart.AddToShopCart(selectedGame);
            }

            return RedirectToAction("Index");

        }

        public IActionResult RemoveItemFromShopCart(int gameId) 
        {
            var selectedGame = _gameRepository.Games.FirstOrDefault(g => g.GameId == gameId);

            if (selectedGame != null)
            {
                _shopCart.RemoveFromShopCart(selectedGame);
            }

            return RedirectToAction("Index");
        }
    }
}
