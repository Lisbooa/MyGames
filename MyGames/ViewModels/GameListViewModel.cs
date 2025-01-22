using MyGames.Models;

namespace MyGames.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public string CurrentGenre { get; set; }
    }
}
