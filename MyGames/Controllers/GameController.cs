using Microsoft.AspNetCore.Mvc;
using MyGames.Repositories.Interfaces;

namespace MyGames.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult List()
        {
            var games = _gameRepository.Games;
            return View(games);
        }
    }
}
