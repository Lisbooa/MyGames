using MyGames.Context;
using MyGames.Models;
using MyGames.Repositories.Interfaces;

namespace MyGames.Repositories
{
    public class GenderRepository : IGenreRepository
    {
        private readonly AppDbContext _context;

        public GenderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> Genders => _context.Genders;
    }
}
