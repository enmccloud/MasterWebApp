/***************************************************************
* Name        : Olympic Flag Website
* Author      : Nikki McCloud
* Created     : 06/29/2020
* Course      : CIS 174 – Adv C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Allows a user to see all associated flags for * *               certain Olympic events/sports.
*			 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using OlympicProgram.Models;
using OlympicProgram1.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;



namespace OlympicProgram.Controllers
{
    public class HomeController : Controller
    {
        private OlyContext Context;

        public HomeController(OlyContext ctx)
        {
            Context = ctx;
        }

        // Pulling all my data from my database and storing them into
        // list form for user view and interaction.
        public ViewResult Index(string activeOlyCat = "all", string activeOlyGame = "all", string activeOlySport = "all")
        {

            Favorite favorite = new Favorite(HttpContext.Session);
            ViewBag.Favorite = favorite.AddFavorite();

            ViewBag.ActiveOlyCat = activeOlyCat;
            ViewBag.ActiveOlyGame = activeOlyGame;
            ViewBag.ActiveOlySport = activeOlySport;

            List<OlyCat> olyCats = Context.OlyCats.ToList();
            List<OlyGame> olyGames = Context.OlyGames.ToList();
            List<OlySport> olySports = Context.OlySports.ToList();

            olyGames.Insert(0, new OlyGame { OlyGameID = "all", OlyGameName = "All" });
            olyCats.Insert(0, new OlyCat { OlyCatID = "all", OlyCatName = "All" });
            olySports.Insert(0, new OlySport { OlySportID = "all", OlySportName = "All" });

            ViewBag.OlyGames = olyGames;
            ViewBag.OlyCats = olyCats;
            ViewBag.OlySports = olySports;

            // Iquerable for showing countries associated w/ chosen item.
            IQueryable<OlyCountry> query = Context.OlyCountries;

            if (activeOlyGame != "all")
                query = query.Where(
                    t => t.OlyGame.OlyGameID.ToLower() == activeOlyGame.ToLower());

            if (activeOlyCat != "all")
                query = query.Where(
                    t => t.OlyCat.OlyCatID.ToLower() == activeOlyCat.ToLower());

            if (activeOlySport != "all")
                query = query.Where(
                    t => t.OlySport.OlySportID.ToLower() == activeOlySport.ToLower());

            var olyCountries = query.ToList();
            return View(olyCountries);
        }
        [HttpGet]
        public IActionResult OnDetail(string name)
        {
            Favorite favorite = new Favorite(HttpContext.Session);

            OlyCountry olyCountry = Context.OlyCountries.Include(t => t.OlySport).Include(t => t.OlyCat).Include(t => t.OlyGame).SingleOrDefault(t => t.OlyCountryName.ToLower() == name.ToLower());

            Detail model = new Detail()
            {
                OlyCountry = olyCountry,
                Favorite = favorite.FavoriteValid(olyCountry),
                FavoriteList = favorite.AddFavorite()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult OnDetail(Detail model)
        {
            Favorite favorite = new Favorite(HttpContext.Session);

            List<OlyCountry> Favorite = favorite.AddFavorite();

            OlyCountry olyCountry = Context.OlyCountries.Include(t => t.OlySport).Include(t => t.OlyCat).Include(t => t.OlyGame).FirstOrDefault(t => t.OlyCountryID == model.OlyCountry.OlyCountryID);

            if (Favorite != null)
            {
                if (Favorite.Find(t => t.OlyCountryID == model.OlyCountry.OlyCountryID) == null)
                {
                    Favorite.Add(olyCountry);
                    favorite.SaveFavorite(Favorite);
                }
            }
            else
            {
                Favorite = new List<OlyCountry>();
                Favorite.Add(olyCountry);
                favorite.SaveFavorite(Favorite);
            }

            RouteValueDictionary favoriteValue = new RouteValueDictionary()
                {
                    {"name", olyCountry.OlyCountryName }
                };

            return RedirectToAction("OnDetail", "Home", favoriteValue);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
