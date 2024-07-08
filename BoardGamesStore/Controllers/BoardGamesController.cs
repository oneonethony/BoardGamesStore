using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BoardGamesStore.Controllers
{
    public class BoardGamesController : Controller
    {
        private readonly ApplicationContext _db;
        public BoardGamesController(ApplicationContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<BoardGame> boardGames = _db.BoardGames.ToList();
            return View(boardGames);
        }
    }
}
