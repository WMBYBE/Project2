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
            var games = ctx.Games.OrderBy(g => g.Name).ToList();
            return View(games);
        }
        public IActionResult Add()
        {
            return View("GameForm");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var g = ctx.Games.Find(Id);
            return View("GameForm", g);
        }

        [HttpPost]
        public IActionResult Edit(Game g)
        {
            if (ModelState.IsValid)
            {

                if (g.Id == 0)
                {
                    ctx.Games.Add(g);
                }
                else
                {
                    ctx.Games.Update(g);
                }
                ctx.SaveChanges();
                var games = ctx.Games.ToList();
                return View("Index", games);
            }
            else
            {
                return View("CharacterForm", g);
            }
        }
        public IActionResult Delete(int id)
        {

            Game del = ctx.Games.Find(id);
            ctx.Games.Remove(del);
            ctx.SaveChanges();
            var g = ctx.Games.ToList();
            return View("Index", g);
        }
    }
}
