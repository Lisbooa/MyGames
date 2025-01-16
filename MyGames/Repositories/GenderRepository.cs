using MyGames.Context;
using MyGames.Models;
using MyGames.Repositories.Interfaces;

namespace MyGames.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        private readonly AppDbContext _context;

        public GenderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Gender> Genders => _context.Genders;
    }
}
