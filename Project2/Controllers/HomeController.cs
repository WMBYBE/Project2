using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using System.Diagnostics;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {

        private GameDbContext ctx { get; set; }

        public HomeController(GameDbContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            var games = ctx.Games.OrderBy(c => c.Name).ToList();
            return View(games);
        }
    }
}
