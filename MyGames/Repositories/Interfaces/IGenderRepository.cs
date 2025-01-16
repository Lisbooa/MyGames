using MyGames.Models;

namespace MyGames.Repositories.Interfaces
{
    public interface IGenderRepository
    {
        IEnumerable<Gender> Genders { get; }
    }
}
