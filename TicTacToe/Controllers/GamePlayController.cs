using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class GamePlayController : Controller
    {
        // GET: GamePlay
        public ActionResult Index()
        {
            Game newGame = new Game();
            return View(newGame);
        }
    }
}