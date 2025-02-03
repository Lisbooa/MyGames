using Microsoft.AspNetCore.Mvc;
using MyGames.Models;
using MyGames.Repositories.Interfaces;

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
            return View();
        }
    }
}
