﻿using Microsoft.AspNetCore.Mvc;
using MyGames.Models;
using MyGames.Repositories.Interfaces;
using MyGames.ViewModels;

namespace MyGames.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult List(string genre)
        {
            IEnumerable<Game> games;
            string currentGenre = string.Empty;

            if (string.IsNullOrEmpty(genre))
            {
                games = _gameRepository.Games.OrderBy(g => g.GameId);
                currentGenre = "Todos os Jogos";
            }
            else 
            {
                if (string.Equals("Aventura", genre, StringComparison.OrdinalIgnoreCase))
                {
                    games = _gameRepository.Games.Where(g => g.Gender.GenderName.Equals("Aventura")).OrderBy(g => g.Name);
                }
                else 
                {
                    games = _gameRepository.Games.Where(g => g.Gender.GenderName.Equals("Terror de Sobrevivência")).OrderBy(g => g.Name);
                }
            }
            var gamesListViewModel = new GameListViewModel
            {
                Games = games,
                CurrentGenre = currentGenre
            };

            return View(gamesListViewModel);
        }
    }
}
