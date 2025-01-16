using MyGames.Models;

namespace MyGames.Repositories.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
        Game GetGameById(int gameId);
    }
}
