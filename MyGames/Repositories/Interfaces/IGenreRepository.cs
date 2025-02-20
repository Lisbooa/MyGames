using MyGames.Models;

namespace MyGames.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Genders { get; }
    }
}
