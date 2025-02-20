using Microsoft.AspNetCore.Mvc;
using MyGames.Repositories.Interfaces;

namespace MyGames.Components
{
    public class GenreMenu : ViewComponent
    {
        private readonly IGenreRepository _genreRepository;

        public GenreMenu(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IViewComponentResult Invoke() 
        {
            var genres = _genreRepository.Genders.OrderBy(g => g.GenderName);
            return View(genres);
        }
    }
}
