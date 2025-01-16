using Microsoft.EntityFrameworkCore;
using MyGames.Context;
using MyGames.Models;
using MyGames.Repositories.Interfaces;

namespace MyGames.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context;
        public GameRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> Games => _context.Games.Include(g => g.Gender);

        public Game GetGameById(int gameId)
        {
            return _context.Games.FirstOrDefault(g => g.GameId == gameId);
        }
    }
}
