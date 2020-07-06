using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OlympicProgram.Models;
using OlympicProgram1.Models;
using System.Collections.Generic;


namespace OlympicProgram1.Controllers
{
    public class FavoriteController : Controller
    {
        [HttpGet]
        public IActionResult Favorite()
        {
            Favorite favorite = new Favorite(HttpContext.Session);
            List<OlyCountry> model = favorite.AddFavorite();
            return View(model);
        }

        [HttpPost]
        public IActionResult Favorite(bool value = false)
        {
            Favorite favorite = new Favorite(HttpContext.Session);
            favorite.SaveFavorite(null);
            return RedirectToAction("Home", "Index");
        }
    }
}
