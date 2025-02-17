using Microsoft.AspNetCore.Mvc;

namespace MyGames.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
